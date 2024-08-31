using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Happy_English.ViewModels;

public partial class DashboardPageViewModel : ObservableObject
{
    public DashboardPageViewModel()
    {
        
    }

    [RelayCommand]
    async void AddWord()
    {
        await Shell.Current.GoToAsync($"{Routes.AddWord}");
    }

    [RelayCommand]
    async void Quiz()
    {
        await Shell.Current.GoToAsync(Routes.Quiz);
    }

    [RelayCommand]
    async void Translate()
    {
        await Shell.Current.GoToAsync(Routes.Translate);
    }
}
