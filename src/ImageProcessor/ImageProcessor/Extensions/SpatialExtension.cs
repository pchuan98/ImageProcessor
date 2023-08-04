using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public static bool Inversion(this Image image, int low = 0, int high = 255, int threshold = 0)
    {
        var thresholdMask = new Mat();
        Cv2.InRange(image.Src, threshold, MaxRange, thresholdMask);

        var a = thresholdMask.GetArray(out byte[] af);
        
        var rangeMask = new Mat();
        Cv2.InRange(image.Src, low, high, rangeMask);

        var ba = rangeMask.GetArray(out byte[] aef);

        var mask = new Mat();
        Cv2.BitwiseAnd(thresholdMask, rangeMask, mask);

        var sdfaf= mask.GetArray(out byte[] aefaf);

        Cv2.BitwiseNot(image.Src, image.Src, mask);
        return true;
    }
}