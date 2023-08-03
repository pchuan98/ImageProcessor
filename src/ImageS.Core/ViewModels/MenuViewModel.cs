using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ImageS.Core.Common;
using ImageS.Core.Messenger;
using ImageS.Core.Services;
using static ImageS.Core.Common.FileFilter;

namespace ImageS.Core.ViewModels;

public partial class MenuViewModel : ObservableObject
{
    private readonly IFileService _fileService;

    public MenuViewModel(IFileService fileService)
    {
        _fileService = fileService;
    }

    [RelayCommand]
    public void ReadWithDialog()
    {
        if (!_fileService.ShowOpenFileDialog(out var collection, FileFilter.ImageFilter, "Open Images",
                isMulti: true)) return;

        foreach (var path in collection)
        {
            var msg = WeakReferenceMessenger.Default.Send<IoMessenger.ReadMessage>(new IoMessenger.ReadMessage()
            {
                Path = path
            });

            var img = msg.Response;

            WeakReferenceMessenger.Default.Send<GalleryMessenger.AddImageMessage>(new GalleryMessenger.AddImageMessage(img));
        }
    }
}