using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImageS.Core.Models.SpatialFiltering;
using ImageS.Core.ViewModels.Processors;

namespace ImageS.Core.ViewModels;

public partial class ProcessorViewModel : ObservableObject
{

    [ObservableProperty]
    private SpatialFilteringViewModel _spatialFiltering = new();

    [RelayCommand]
    public void Reset() => MessageManager.Reset();

    [RelayCommand]
    public void Fixed() => MessageManager.Fixed();
}