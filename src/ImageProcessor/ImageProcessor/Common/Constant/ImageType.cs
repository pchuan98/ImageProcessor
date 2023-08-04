using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Common.Constant;

public enum ImageType
{
    /// <summary>
    /// File type is not known.
    /// </summary>
    Unknown = 0,

    /// <summary>
    /// Joint Photographic Experts Group (JPEG).
    /// </summary>
    Jpeg = 1,

    /// <summary>
    /// Tagged Image File Format (TIFF).
    /// </summary>
    Tiff = 2,

    /// <summary>
    /// Portable Network Graphic (PNG).
    /// </summary>
    Png = 3,

    /// <summary>
    /// Bitmap (BMP).
    /// </summary>
    Bmp = 4,

    /// <summary>
    /// Graphics Interchange Format (GIF).
    /// </summary>
    Gif = 5,

    /// <summary>
    /// Windows Icon.
    /// </summary>
    Ico = 6,

    /// <summary>
    /// WebP.
    /// </summary>
    WebP = 7,

    /// <summary>
    /// High Efficiency Image File Format.
    /// </summary>
    Heif = 8,
}
