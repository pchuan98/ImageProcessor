using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor.Common.Models;

namespace ImageS.Core.ViewModels;

public partial class GalleryViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Image> _images = new ObservableCollection<Image>();


}