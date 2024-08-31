using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class AddWord : ContentPage
{
	private AddWordPageViewModel _viewModel;
	public AddWord(AddWordPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = vm;
	}
}