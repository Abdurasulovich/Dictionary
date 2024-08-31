using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class Search : ContentPage
{
    private SearchPageViewModel _viewModel;
	public Search(SearchPageViewModel viewmodel)
	{
		InitializeComponent();
        this.BindingContext = _viewModel = viewmodel;
	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        _viewModel.Search(e.NewTextValue);
    }
}