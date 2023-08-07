using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;
using OpenCvSharp;

namespace ImageProcessor.Extensions;

public static class LutExtension
{
    public static void SetLut(this Image image, LutColormap colors, Image? mask = null)
    {
        if ((int)colors == -1 && mask == null)
            throw new Exception("Set up a custom LUT (Lookup Table), and a mask is necessary.");

        if ((int)colors != -1)
        {
            Cv2.ApplyColorMap(image.Original, image.Present, (ColormapTypes)colors);
            return;
        }

        Cv2.ApplyColorMap(image.Original, image.Present, mask!.Original);
        return;
    }

    /// <summary>
    /// Monochromatic
    /// </summary>
    public static void SetMonoLut()
    {
        
    }
}