using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;

namespace ImageS.Core.Messenger;

public class GalleryMessenger
{
    public record AddImageMessage(Image ImageObject);
}