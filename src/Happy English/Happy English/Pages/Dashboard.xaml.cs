using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class Dashboard : ContentPage
{
	private DashboardPageViewModel _viewModel;
	public Dashboard(DashboardPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = vm;
	}
}