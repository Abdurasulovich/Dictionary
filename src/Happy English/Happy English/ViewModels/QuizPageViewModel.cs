using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Happy_English.ViewModels;

public partial class QuizPageViewModel : ObservableObject
{
    public QuizPageViewModel()
    {
        
    }

    [RelayCommand]
    async void Start()
    {
        await Shell.Current.GoToAsync(Routes.QuizStart);

    }
}
