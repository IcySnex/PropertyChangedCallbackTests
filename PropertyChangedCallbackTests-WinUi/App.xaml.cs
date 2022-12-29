using Microsoft.UI.Xaml;
using PropertyChangedCallbackTests_WinUi.Views;

namespace PropertyChangedCallbackTests_WinUi;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override void OnLaunched(LaunchActivatedEventArgs args)
    {
        MainWindow window = new();
        window.ContentFrame.Navigate(typeof(DefaultView));

        window.Activate();
    }
}