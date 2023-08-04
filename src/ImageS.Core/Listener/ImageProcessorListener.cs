using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Extensions;
using ImageS.Core.Messenger;

namespace ImageS.Core.Listener;

public class ImageProcessorListener :
    IRecipient<ImageProcessorMessenger.ImageProcessorConverterMessage>
{
    public ImageProcessorListener()
    {
        WeakReferenceMessenger.Default.Register<ImageProcessorMessenger.ImageProcessorConverterMessage>(this);
    }

    public void Receive(ImageProcessorMessenger.ImageProcessorConverterMessage message)
    {
        var func = message.FuncName;
        var img = message.Image;

        if (func == "ToGray") img.ToGray();


        WeakReferenceMessenger.Default.Send<PresentMessenger.RefreshPresent>(
                       new PresentMessenger.RefreshPresent());
        WeakReferenceMessenger.Default.Send<GalleryMessenger.RefreshThumbnailsMessage>(
                       new GalleryMessenger.RefreshThumbnailsMessage(img));
    }
}