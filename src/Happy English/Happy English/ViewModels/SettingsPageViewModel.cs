using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Happy_English.ViewModels;

public partial class SettingsPageViewModel : ObservableObject
{
    public SettingsPageViewModel()
    {
        AppMode = "Light";
    }
    [ObservableProperty]
    string appMode;
    [ObservableProperty]
    string ligthMode = "Ligth";
    [ObservableProperty]
    string darkMode = "Dark";
    [ObservableProperty]
    string systemMode = "Default";
    [ObservableProperty]
    bool isModeSelectorVisible = false;

    [RelayCommand]
    void ModeSelector()
    {
        IsModeSelectorVisible = !IsModeSelectorVisible;
    }

    [RelayCommand]
    void Light()
    {
        AppMode = LigthMode;
        IsModeSelectorVisible = false;
    }

    [RelayCommand]
    void Dark()
    {
        AppMode = DarkMode;
        IsModeSelectorVisible = false;
    }

    [RelayCommand]
    void System()
    {
        AppMode = SystemMode;
        IsModeSelectorVisible = false;
    }
}
