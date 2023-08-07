using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Constant;
using ImageProcessor.Services;
using OpenCvSharp;


namespace ImageProcessor.Common.Models;

using static System.Net.Mime.MediaTypeNames;

#if NET35
using DirectoryList = System.Collections.Generic.IList<MetadataExtractor.Directory>;
#else
using DirectoryList = System.Collections.Generic.IReadOnlyList<MetadataExtractor.Directory>;
#endif

public class Image : IDisposable
{
    /// <summary>
    /// 原始对象
    /// </summary>
    internal Mat Original { get; set; } = new();

    public Mat GetOriginal() => Original;

    /// <summary>
    /// 处理对象，用来承载显示效果
    /// </summary>
    public Mat Present { get; set; } = new();

    /// <summary>
    /// 
    /// </summary>
    public DirectoryList? Metadatas { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public ImageType ImageType { get; set; }

    #region Constructors

    public Image() { }

    public Image(string path)
    {
        Original = Cv2.ImRead(path);
        Original.CopyTo(Present);

    }

    public Image(Image image)
    {
        image.Original.CopyTo(Original);
        image.Present.CopyTo(Present);
    }

    public Image(byte[] array, ImageType type)
    {

    }

    public Image(Stream stream)
    {

    }

    #endregion

    /// <summary>
    /// 
    /// </summary>
    public void Fixed() => Present.CopyTo(Original);

    /// <summary>
    /// 
    /// </summary>
    public void Reset() => Original.CopyTo(Present);

    public void Dispose()
    {
        Original?.Dispose();
        Present?.Dispose();
    }
}