using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class Settings : ContentPage
{
	private SettingsPageViewModel _viewmodel;
	public Settings(SettingsPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewmodel = vm;
	}
}