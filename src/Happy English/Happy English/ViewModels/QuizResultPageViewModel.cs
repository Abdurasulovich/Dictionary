using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace Happy_English.ViewModels;

public partial class QuizResultPageViewModel : ObservableObject
{
    public QuizResultPageViewModel()
    {
        IsConfettiVisible = false;
    }

    [ObservableProperty]
    bool isConfettiVisible;
    [ObservableProperty]
    float progress = 0f;
    [ObservableProperty]
    string resultValue = "0";


    public async Task OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        //ResultValue = (progress * 100).ToString("F2");

        var canvas = e.Surface.Canvas;
        canvas.Clear();

        float width = e.Info.Width;
        float height = e.Info.Height;
        float radius = Math.Min(width, height) / 2;
        float strokeWidth = 50;

        var paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            Color = SKColor.Parse("#808B97"),
            StrokeWidth = strokeWidth,
            IsAntialias = true,
        };

        var center = new SKPoint(width / 2, height / 2);

        // Draw the background circle
        canvas.DrawCircle(center, radius - strokeWidth / 2, paint);

        // Draw the progress arc
        paint.Color = SKColor.Parse("#78B7BB");

        using (var path = new SKPath())
        {
            path.AddArc(new SKRect(strokeWidth / 2, strokeWidth / 2, width - strokeWidth / 2, height - strokeWidth / 2),
                        -90, 360 * Progress);
            canvas.DrawPath(path, paint);
        }
    }

    [RelayCommand]
    async Task MainPage()
    {
        await Shell.Current.GoToAsync(Routes.Dashboard);
        ResultValue = "";
        Progress = 0f;
        IsConfettiVisible = false;
    }
}
