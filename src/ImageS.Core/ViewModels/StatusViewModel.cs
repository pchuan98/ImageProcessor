using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using ImageS.Core.Messenger;

namespace ImageS.Core.ViewModels;

public partial class StatusViewModel : ObservableObject,
    IRecipient<InfoMessenger.RightStatusMessage>,
    IRecipient<InfoMessenger.LeftStatusMessage>
{
    public StatusViewModel()
    {
        WeakReferenceMessenger.Default.Register<InfoMessenger.RightStatusMessage>(this);
        WeakReferenceMessenger.Default.Register<InfoMessenger.LeftStatusMessage>(this);
    }

    [ObservableProperty] 
    private string _leftMessage = "";

    [ObservableProperty] 
    private string _rightMessage = "";

    public void Receive(InfoMessenger.RightStatusMessage message)
        => RightMessage = message.Message;

    public void Receive(InfoMessenger.LeftStatusMessage message)
        => LeftMessage = message.Message;

}