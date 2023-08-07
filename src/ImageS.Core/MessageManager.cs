using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;

namespace ImageS.Core;

public static class MessageManager
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public static Image GetSelectedImage()
    {
        var image = WeakReferenceMessenger.Default.Send<GalleryMessenger.GetSelectedImageMessage>().Response;
        return image ?? throw new Exception();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static void RefreshPresent()
        => WeakReferenceMessenger.Default.Send(new PresentMessenger.RefreshPresent());

    /// <summary>
    /// 
    /// </summary>
    /// <param name="img">需要更新的gallery的缩略图，根据给的image来锁定位置</param>
    public static void RefreshThumbnail(Image img)
        => WeakReferenceMessenger.Default.Send(new GalleryMessenger.RefreshThumbnailsMessage(img));

    /// <summary>
    /// 处理结果保存
    /// </summary>
    public static void Fixed()
        => WeakReferenceMessenger.Default.Send(new ImageProcessorMessenger.FixedProcessorMessage());

    public static void Reset()
        => WeakReferenceMessenger.Default.Send(new ImageProcessorMessenger.ResetProcessorMessage());

}