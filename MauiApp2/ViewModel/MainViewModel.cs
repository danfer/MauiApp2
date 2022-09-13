
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace MauiApp2.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;       
    }
}
