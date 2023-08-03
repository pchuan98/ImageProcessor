using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Constant;
using ImageProcessor.Services;
using OpenCvSharp;


namespace ImageProcessor.Common.Models;

#if NET35
using DirectoryList = System.Collections.Generic.IList<MetadataExtractor.Directory>;
#else
using DirectoryList = System.Collections.Generic.IReadOnlyList<MetadataExtractor.Directory>;
#endif

public class Image : IDisposable
{
    /// <summary>
    /// 处理对象
    /// </summary>
    internal Mat Src { get; set; } = new();

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
        => Src = Cv2.ImRead(path, (ImreadModes)(-1));

    public Image(Image image)
        => image.Src.CopyTo(Src);

    public Image(byte[] array, ImageType type)
    {

    }

    public Image(Stream stream)
    {

    }

    #endregion


    public void Dispose()
    {
        Src?.Dispose();
    }
}