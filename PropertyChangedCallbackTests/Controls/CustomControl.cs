using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PropertyChangedCallbackTests.Controls;

public class CustomControl : ContentControl
{
    static CustomControl()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new FrameworkPropertyMetadata(typeof(CustomControl)));
    }


    private static void OnIsCheckedChanged(
        DependencyObject sender,
        DependencyPropertyChangedEventArgs e)
    {
        CustomControl owner = (CustomControl)sender;

        Debug.WriteLine($"[DependencyObject-OnIsCheckedChanged]  PropertyChangedCallback got called. IsChecked: {owner.IsChecked}");

        owner.VerificationRequestedCommand.Execute(null);
    }

    public bool IsChecked
    {
        get => (bool)GetValue(IsCheckedProperty);
        set => SetValue(IsCheckedProperty, value);
    }

    public static readonly DependencyProperty IsCheckedProperty = DependencyProperty.Register(
        "IsChecked", typeof(bool), typeof(CustomControl), new PropertyMetadata(false, OnIsCheckedChanged));


    public ICommand VerificationRequestedCommand
    {
        get => (ICommand)GetValue(VerificationRequestedCommandProperty);
        set => SetValue(VerificationRequestedCommandProperty, value);
    }

    public static readonly DependencyProperty VerificationRequestedCommandProperty = DependencyProperty.Register(
        "VerificationRequestedCommand", typeof(ICommand), typeof(CustomControl), new PropertyMetadata(null));
}