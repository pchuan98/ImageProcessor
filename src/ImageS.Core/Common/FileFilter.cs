using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageS.Core.Common;

public static class FileFilter
{
    public const string ImageFilter = "Image files|*.png;*.jpeg;*.jpg;*.bmp;*.tif;*.tiff|" +
                                      "PNG|*.png|" +
                                      "JPEG|*.jpeg;*.jpg|" +
                                      "BMP|*.bmp|" +
                                      "TIF|*.tif;*.tiff|" +
                                      "All files (*.*)|*.*";
}
