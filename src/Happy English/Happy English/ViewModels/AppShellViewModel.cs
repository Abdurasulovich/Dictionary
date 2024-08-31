using Happy_English.Pages;
using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace Happy_English.ViewModels;

public partial class AppShellViewModel : ObservableObject
{
    public AppShellViewModel()
    {
        DashboardIcon = "dashboard.png";
        SearchIcon = "search.png";
        SettingsIcon = "settings.png";
    }
    [ObservableProperty]
    string dashboardIcon;
    [ObservableProperty]
    string searchIcon;
    [ObservableProperty]
    string settingsIcon;

    public void UpdateIcons(string selectedTab)
    {
        DashboardIcon = "dashboard.png";
        SearchIcon = "search.png";
        SettingsIcon = "settings.png";

        switch (selectedTab)
        {
            case "D_FAULT_ShellContent2":
                DashboardIcon = "selectdashboard.png";
                break;
            case "D_FAULT_ShellContent4":
                SearchIcon = "selectedsearch.png";
                break;
            case "D_FAULT_ShellContent6":
                SettingsIcon = "selectedsettings.png";
                break;
        }
    }
}
