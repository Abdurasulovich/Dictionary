using CommunityToolkit.Maui.Core.Platform;
using Happy_English.ViewModels;

namespace Happy_English.Pages;

public partial class Translate : ContentPage
{
	private TranslatePageViewModel _viewModel;
	public Translate(TranslatePageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewModel = vm;
	}

    private void myEditor_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
		_viewModel.IsEditorHasValue();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		myEditor.Unfocus();
		await KeyboardExtensions.HideKeyboardAsync(myEditor);
		_viewModel.IsSpeakerVisible = true;
		_viewModel.IsComplatedVisible = false;
    }
}