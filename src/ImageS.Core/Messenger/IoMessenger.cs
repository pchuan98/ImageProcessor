using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging.Messages;
using ImageProcessor.Common.Models;

namespace ImageS.Core.Messenger;

public static class IoMessenger
{
    /// <summary>
    /// 
    /// </summary>
    public class AsyncReadMessage : AsyncRequestMessage<Image>
    {
        public string? Path { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ReadMessage : RequestMessage<Image>
    {
        public string? Path { get; set; }
    }
}