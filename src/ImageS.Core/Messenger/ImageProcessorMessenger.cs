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
    /// <param name="Object"></param>
    /// <param name="FuncName"></param>
    public record ConverterMessage(Image Object, string FuncName);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="Object"></param>
    /// <param name="FuncName"></param>
    /// <param name="Value"></param>
    public record SpatialMessage<T>(Image Object, string FuncName, T Value);

    /// <summary>
    /// 锁定修改
    /// </summary>
    public record FixedProcessorMessage();

    /// <summary>
    /// 重置修改
    /// </summary>
    public record ResetProcessorMessage();
}