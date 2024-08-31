using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class TranslateSaved : ContentPage
{
	private TranslateSavedPageViewModel _viewModel;
	public TranslateSaved(TranslateSavedPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = vm;
	}
}