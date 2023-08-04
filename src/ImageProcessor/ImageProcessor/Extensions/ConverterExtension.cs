using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;
using OpenCvSharp;

namespace ImageProcessor.Extensions;

/**
 * TODO
 * 色彩空间转换
 */

/// <summary>
/// 
/// </summary>
public static class ConverterExtension
{
    public static bool ToGray(this Image image)
    {
        Cv2.CvtColor(image.Src, image.Src, ColorConversionCodes.BGR2GRAY);
        return true;
    }

    #region ColorSpace

    

    #endregion
}