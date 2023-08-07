using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Extensions;
using ImageS.Core.Messenger;
using ImageS.Core.Models;

namespace ImageS.Core.Listener;

public class ImageProcessorListener :
    IRecipient<ImageProcessorMessenger.ConverterMessage>,
    IRecipient<ImageProcessorMessenger.SpatialMessage<TripleValue<int>>>,
    IRecipient<ImageProcessorMessenger.FixedProcessorMessage>,
    IRecipient<ImageProcessorMessenger.ResetProcessorMessage>
{
    public ImageProcessorListener()
    {
        WeakReferenceMessenger.Default.Register<ImageProcessorMessenger.ConverterMessage>(this);
        WeakReferenceMessenger.Default.Register<ImageProcessorMessenger.SpatialMessage<TripleValue<int>>>(this);
        WeakReferenceMessenger.Default.Register<ImageProcessorMessenger.FixedProcessorMessage>(this);
        WeakReferenceMessenger.Default.Register<ImageProcessorMessenger.ResetProcessorMessage>(this);
    }

    public void Receive(ImageProcessorMessenger.ConverterMessage message)
    {
        var func = message.FuncName;
        var img = message.Object;

        if (func == "ToGray") img.ToGray();

        img.Fixed();

        MessageManager.RefreshPresent();
        MessageManager.RefreshThumbnail(img);
    }

    public void Receive(ImageProcessorMessenger.SpatialMessage<TripleValue<int>> message)
    {
        var func = message.FuncName;
        var img = message.Object;
        var triple = message.Value;

        if (func == "SetInversion") img.SetInversion(triple.Minimum, triple.Maximum, triple.Threshold);
    }

    public void Receive(ImageProcessorMessenger.FixedProcessorMessage message)
        => MessageManager.GetSelectedImage().Fixed();

    public void Receive(ImageProcessorMessenger.ResetProcessorMessage message)
        => MessageManager.GetSelectedImage().Reset();
}