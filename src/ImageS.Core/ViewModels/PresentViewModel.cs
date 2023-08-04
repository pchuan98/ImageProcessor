using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using ImageProcessor.Common.Models;
using ImageS.Core.Messenger;

namespace ImageS.Core.ViewModels;

public partial class PresentViewModel : ObservableObject,
    IRecipient<PresentMessenger.SwitchPresentMessage>,
    IRecipient<PresentMessenger.RefreshPresent>
{
    public PresentViewModel()
    {
        WeakReferenceMessenger.Default.Register<PresentMessenger.SwitchPresentMessage>(this);
        WeakReferenceMessenger.Default.Register<PresentMessenger.RefreshPresent>(this);
    }

    [ObservableProperty]
    private Image? _present;

    public void Receive(PresentMessenger.SwitchPresentMessage message)
    {
        Present = message.Present;
    }

    public void Receive(PresentMessenger.RefreshPresent message)
    {
        var present = Present;
        Present = null;
        Present = present;
    }
}