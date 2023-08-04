using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;

namespace ImageS.Core.Messenger;

public static class ImageProcessorMessenger
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Image"></param>
    /// <param name="FuncName"></param>
    public record ImageProcessorConverterMessage(Image Image, string FuncName);
}