using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Happy_English.ViewModels;

public partial class QuizStartPageViewModel : ObservableObject
{
    public QuizStartPageViewModel()
    {
        Variants = new ObservableCollection<string>
        {
            "Akobir",
            "Javohir",
            "Islom",
            "Og'abek"
        };
        SelectedItem = "";
        Question = "What is your name?";
    }
    [ObservableProperty]
    ObservableCollection<string> variants;
    [ObservableProperty]
    string selectedItem;
    [ObservableProperty]
    bool isNextButtonVisible= false;

    [ObservableProperty]
    string question;

    [RelayCommand]
    void SelectedVariand(string result)
    {
        SelectedItem = result;
        IsNextButtonVisible = true;
    }

    [RelayCommand]
    async void NextQuestion()
    {
        IsNextButtonVisible = false;
        await Shell.Current.GoToAsync(Routes.QuizResult);
    }
}
