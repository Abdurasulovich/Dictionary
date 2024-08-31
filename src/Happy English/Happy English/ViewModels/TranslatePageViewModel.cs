using CommunityToolkit.Maui.Core.Platform;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Happy_English.ViewModels;

public partial class TranslatePageViewModel : ObservableObject
{
    public TranslatePageViewModel()
    {
        Text = "";
        IsSeperatorVisible = false;
        IsSpeakerVisible = false;
        IsComplatedVisible = false;
    }
    [ObservableProperty]
    string text;
    [ObservableProperty]
    bool isSeperatorVisible;
    [ObservableProperty]
    bool isSpeakerVisible;
    [ObservableProperty]
    bool isComplatedVisible;

    [RelayCommand]
    async void Saved()
    {
        await Shell.Current.GoToAsync(Routes.TranslateSaved);
    }

    [RelayCommand]
    async void Back()
    {
        await Shell.Current.GoToAsync(Routes.Dashboard);
        Text = "";
    }

    public void IsEditorHasValue()
    {
        if (!string.IsNullOrWhiteSpace(Text))
        {
            IsSeperatorVisible = true;
            IsComplatedVisible = true;
            IsSpeakerVisible = false;
        }
        else
        {
            IsSeperatorVisible = false;
            IsComplatedVisible = false;
        }
    }
}
