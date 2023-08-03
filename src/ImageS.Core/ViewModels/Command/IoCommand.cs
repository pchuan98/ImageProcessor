﻿using CommunityToolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;
using ImageS.Core.Services;
using static ImageS.Core.Messenger.IoMessenger;

namespace ImageS.Core.ViewModels.Command;

/// <summary>
/// 读写IO
/// </summary>
public partial class IoCommand : ObservableObject, IRecipient<ReadMessage>,
    IRecipient<AsyncReadMessage>
{
    private readonly ILogService _logService;

    public IoCommand(ILogService logService)
    {
        Debug.WriteLine("生成对象");
        _logService = logService;

        WeakReferenceMessenger.Default.Register<ReadMessage>(this);
        WeakReferenceMessenger.Default.Register<AsyncReadMessage>(this);
    }

    public void Receive(ReadMessage message)
    {
        _logService?.Debug("[FileViewModel] - [Receive] - Read a File.");

        var path = message.Path;

        if (string.IsNullOrEmpty(path)) throw new NoNullAllowedException();
        _logService?.Debug("1");

        try
        {
            _logService?.Debug("2");
            var img = new Image(path);
            message.Reply(img);
            _logService?.Debug("3");

        }
        catch (Exception e)
        {
            _logService?.Error(e.Message, e);
        }
    }

    public void Receive(AsyncReadMessage message)
    {
        
    }

    ~IoCommand()
    {
        Debug.WriteLine("对象被回收");
    }
}