using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;
using ImageS.Core.Services;
using static ImageS.Core.Messenger.IoMessenger;

namespace ImageS.Core.ViewModels.Command;

/// <summary>
/// 读写IO
/// </summary>
public class IoCommand : IRecipient<ReadMessage>
{
    private readonly ILogService _logService;

    public IoCommand(ILogService logService)
    {
        _logService = logService;
    }

    public void Receive(ReadMessage message)
    {
        _logService?.Debug("[FileViewModel] - [Receive] - Read a File.");

        var path = message.Path;

        if (string.IsNullOrEmpty(path)) throw new NoNullAllowedException();

        try
        {
            var img = new Image(path);
            message.Reply(img);

        }
        catch (Exception e)
        {
            _logService?.Error(e.Message, e);
        }
    }
}