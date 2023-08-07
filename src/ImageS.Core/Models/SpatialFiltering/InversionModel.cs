using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;

namespace ImageS.Core.Models.SpatialFiltering;

/// <summary>
/// 
/// </summary>
public partial class InversionModel : ObservableObject
{
    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private int _min = 0;

    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private int _max = 255;

    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private int _threadShold = 0;


    partial void OnMinChanged(int value)
        => SendMessage();


    partial void OnMaxChanged(int value)
        => SendMessage();

    partial void OnThreadSholdChanged(int value)
        => SendMessage();

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public TripleValue<int> ToTriple()
        => new(Min, Max, ThreadShold);

    void SendMessage()
    {
        var image = MessageManager.GetSelectedImage();

        WeakReferenceMessenger.Default.Send<ImageProcessorMessenger.SpatialMessage<TripleValue<int>>>
            (new(image, "SetInversion", ToTriple()));

        MessageManager.RefreshPresent();
        MessageManager.RefreshThumbnail(image);
    }
}