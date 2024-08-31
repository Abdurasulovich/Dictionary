using System.Globalization;

namespace Happy_English.Helpers;

public class TextToGridLengthConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is string text && string.IsNullOrEmpty(text))
        {
            return new GridLength(1, GridUnitType.Star); // * when the text is empty
        }
        else
        {
            return new GridLength(1, GridUnitType.Auto); // Auto when the text is not empty
        }
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
