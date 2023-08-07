using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using ImageS.Core.Models.SpatialFiltering;

namespace ImageS.Core.ViewModels.Processors;

public partial class SpatialFilteringViewModel:ObservableObject
{
    [ObservableProperty]
    private InversionModel _inversion = new();
}