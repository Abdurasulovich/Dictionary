using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Happy_English.ViewModels;

public partial class TranslateSavedPageViewModel : ObservableObject
{
    public TranslateSavedPageViewModel()
    {
        
    }

    [ObservableProperty]
    bool isRefreshing = false;

    [RelayCommand]
    async void Refresh()
    {
        IsRefreshing = true;
        Thread.Sleep(1000);
        IsRefreshing = false;
    }

    [RelayCommand]
    async void Back()
    {
        Shell.Current.GoToAsync("..");
    }
}
