using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class QuizStart : ContentPage
{
	private QuizStartPageViewModel _viewmodel;
	public QuizStart(QuizStartPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewmodel = vm;
	}
}