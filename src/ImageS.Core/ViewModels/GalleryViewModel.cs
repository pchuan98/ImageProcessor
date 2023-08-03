using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;

namespace ImageS.Core.ViewModels;

public partial class GalleryViewModel : ObservableObject,
    IRecipient<GalleryMessenger.AddImageMessage>
{
    public GalleryViewModel()
    {
        WeakReferenceMessenger.Default.Register<GalleryMessenger.AddImageMessage>(this);
    }

    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<Image> _images
            = new ObservableCollection<Image>();


    public void Receive(GalleryMessenger.AddImageMessage message)
        => Images.Add(message.ImageObject);
}