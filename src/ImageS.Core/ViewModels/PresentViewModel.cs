using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ImageProcessor.Common.Models;
namespace ImageS.Core.ViewModels;

public partial class PresentViewModel : ObservableObject
{
    [ObservableProperty]
    private Image? _present;
}