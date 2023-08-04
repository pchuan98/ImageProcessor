using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;
using ImageProcessor.Common.Models;

namespace ImageS.Core.Messenger;

public class GalleryMessenger
{
    public record AddImageMessage(Image ImageObject);

    public class GetSelectedImageMessage : RequestMessage<Image?> { }

    public record RefreshThumbnailsMessage(Image? ImageObject);
}