//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Media.Imaging;
//using ImageProcessor.Common.Models;
//using OpenCvSharp;
//using OpenCvSharp.WpfExtensions;
//using static MetadataExtractor.Formats.Bmp.BmpHeaderDirectory;

//namespace ImageProcessor.Extensions;

//public static class WpfExtension
//{
//    /// <summary>
//    /// 
//    /// </summary>
//    /// <param name="image"></param>
//    /// <param name="source"></param>
//    /// <param name="compression">Compression scale : 0 - 1</param>
//    /// <returns></returns>
//    public static bool ToBitmapSourceThumbnail(this Image image, out BitmapSource source, double compression = 0.1)
//    {
//        var tn = new Mat();
//        Cv2.Resize(image.Original, tn, new Size(0, 0), compression, compression);

//        source = tn.ToBitmapSource();
//        return true;
//    }

//    public static bool ToBitmapSource(this Image image, out BitmapSource source)
//    {
//        source = image.Original.ToBitmapSource();
//        return true;
//    }
//}
