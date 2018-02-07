using System;
using Xamarin.Forms;
using System.Globalization;

namespace XamarinEvolve.Clients.UI
{
    /// <summary>
    /// Is favorite text converter.
    /// </summary>
    class IsFavoriteTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            
            return (bool)value ? "Beğenme" : "Beğen";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Is favorite detail text converter.
    /// </summary>
    class IsFavoriteDetailTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            
            return (bool)value ? "Beğenilenlerden Kaldır" : "Beğenilenlere Ekle";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Has reminder event text converter.
    /// </summary>
    class HasReminderEventTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            

            return (bool)value ? "Takvimden Kaldır" : "Takvime Ekle";
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Has reminder text converter.
    /// </summary>
    class HasReminderTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return string.Empty;
            
            return (bool)value ? "Takvimden Kaldır" : "Takvime Ekle";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
       
}

