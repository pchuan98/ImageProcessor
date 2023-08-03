using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;
using ImageS.Core.Services;
using static ImageS.Core.Messenger.IoMessenger;

namespace ImageS.Core.Listener;

public class IoListener : IRecipient<ReadMessage>,
    IRecipient<AsyncReadMessage>
{
    private readonly ILogService _logService;

    public IoListener(ILogService logService)
    {
        _logService = logService;

        _logService.Trace("IoListener 生成对象");

        WeakReferenceMessenger.Default.Register<ReadMessage>(this);
        WeakReferenceMessenger.Default.Register<AsyncReadMessage>(this);
    }

    public void Receive(ReadMessage message)
    {
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

    public void Receive(AsyncReadMessage message)
    {

    }

    ~IoListener()
    {
        _logService.Warn("IoListener 对象被回收");
    }
}