using Microsoft.UI.Xaml.Data;
using System;

namespace PropertyChangedCallbackTests_WinUi.Controls;

class BoolStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language) => 
        ((bool)value).ToString();

    public object ConvertBack(object value, Type targetType, object parameter, string language) =>
        (string)value == "True";
}