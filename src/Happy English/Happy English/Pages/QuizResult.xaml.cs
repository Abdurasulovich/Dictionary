using Happy_English.ViewModels;
using SkiaSharp;
using SkiaSharp.Views.Maui;
using System.Timers;

namespace Happy_English.Pages;

public partial class QuizResult : ContentPage
{
    private QuizResultPageViewModel _viewmodel;
	public QuizResult(QuizResultPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = _viewmodel = vm;

        _viewmodel.PropertyChanged += (sender, args) =>
        {
            if (args.PropertyName == nameof(_viewmodel.Progress))
            {
                canvasView.InvalidateSurface();
            }
        };
    }
    private async Task AnimateImage()
    {
        imageContainer.Scale = 0;
        await imageContainer.ScaleTo(1, 500, Easing.BounceOut);
    }


    private async void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        await _viewmodel.OnCanvasViewPaintSurface(sender, e);
        if (_viewmodel.ResultValue != "42.18")
        {
            await Nimadur(0.0111f);
            await AnimateImage();
        }
        else
        {
            _viewmodel.IsConfettiVisible = true;
            Confitte.RepeatCount = 1;
        }
    }

    private async Task Nimadur(float value)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            _viewmodel.Progress += value;
            _viewmodel.ResultValue = (_viewmodel.Progress * 100).ToString("F2");
        });
    }


}