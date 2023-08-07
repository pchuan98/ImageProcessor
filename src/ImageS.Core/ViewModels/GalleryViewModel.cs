using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Constant;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;

namespace ImageS.Core.ViewModels;

public partial class GalleryViewModel : ObservableObject,
    IRecipient<GalleryMessenger.AddImageMessage>,
    IRecipient<GalleryMessenger.GetSelectedImageMessage>,
    IRecipient<GalleryMessenger.RefreshThumbnailsMessage>

{
    public GalleryViewModel()
    {
        Register();
    }

    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<Image> _images
            = new ObservableCollection<Image>();


    /// <summary>
    /// 
    /// </summary>
    [ObservableProperty]
    private Image? _selectedImage;

    partial void OnSelectedImageChanged(Image? value)
    {
        if (value != null)
            WeakReferenceMessenger.Default.Send<PresentMessenger.SwitchPresentMessage>(
                new PresentMessenger.SwitchPresentMessage(value));
    }


    #region Receive

    void Register()
    {
        WeakReferenceMessenger.Default.Register<GalleryMessenger.AddImageMessage>(this);
        WeakReferenceMessenger.Default.Register<GalleryMessenger.GetSelectedImageMessage>(this);
        WeakReferenceMessenger.Default.Register<GalleryMessenger.RefreshThumbnailsMessage>(this);

    }

    public void Receive(GalleryMessenger.AddImageMessage message)
        => Images.Add(message.ImageObject);

    public void Receive(GalleryMessenger.GetSelectedImageMessage message)
        => message.Reply(SelectedImage);

    public void Receive(GalleryMessenger.RefreshThumbnailsMessage message)
    {
        var index = Images.IndexOf(message.ImageObject!);

        var img = Images[index];


        Images[index] = null!;
        Images[index] = img;

    }

    #endregion


}