using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class Quiz : ContentPage
{
	private QuizPageViewModel _viewModel;
	public Quiz(QuizPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = vm;
	}
}