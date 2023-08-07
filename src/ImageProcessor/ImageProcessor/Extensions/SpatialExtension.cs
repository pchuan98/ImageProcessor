using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Constant;
using ImageProcessor.Common.Models;
using OpenCvSharp;

namespace ImageProcessor.Extensions;

/// <summary>
/// Spatial Filtering extension
/// </summary>
public static class SpatialExtension
{
    public const int MaxRange = 255;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="image"></param>
    /// <param name="low"></param>
    /// <param name="high"></param>
    /// <param name="threshold"></param>
    /// <returns></returns>
    public static bool SetInversion(this Image image, int low = 0, int high = 255, int threshold = 0)
    {
        var thresholdMask = new Mat();
        Cv2.InRange(image.Original, threshold, MaxRange, thresholdMask);

        var a = thresholdMask.GetArray(out byte[] af);

        var rangeMask = new Mat();
        Cv2.InRange(image.Original, low, high, rangeMask);

        var ba = rangeMask.GetArray(out byte[] aef);

        var mask = new Mat();
        Cv2.BitwiseAnd(thresholdMask, rangeMask, mask);

        var sdfaf = mask.GetArray(out byte[] aefaf);

        Cv2.BitwiseNot(image.Original, image.Present, mask);
        return true;
    }

    // TODO 后面两个函数需要改成分段，需要借助mask

    /// <summary>
    /// s = c * log(r+1)
    /// </summary>
    /// <param name="image"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static bool SetLog(this Image image, double c = 1)
    {
        image.Original.ConvertTo(image.Present, MatType.CV_32F);

        Cv2.MinMaxLoc(image.Original, out double a, out double b);

        Cv2.Log(image.Present + 1, image.Present);
        image.Present *= c;

        image.Present.MinMaxLoc(out double min, out double max);

        // norm
        var top = image.Present - min;
        var bottom = max - min;
        var scale = MaxRange - 0;

        var norm = (top / bottom) * scale;
        image.Present = norm.ToMat();

        image.Present.ConvertTo(image.Present, image.Original.Type());

        return true;
    }

    /// <summary>
    /// s = c * pow(r,γ)
    /// </summary>
    /// <param name="image"></param>
    /// <param name="c"></param>
    /// <param name="gamma"></param>
    /// <returns></returns>
    public static bool SetGamma(this Image image,  double gamma = 1)
    {
        image.Original.ConvertTo(image.Present, MatType.CV_32F);
        Cv2.Pow(image.Present / 255.0, gamma, image.Present);
        Cv2.Normalize(image.Present, image.Present, 0, MaxRange, NormTypes.MinMax, image.Original.Type());
        return true;
    }


}