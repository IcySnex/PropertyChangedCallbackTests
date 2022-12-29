using PropertyChangedCallbackTests.ViewModels;
using System.Windows;

namespace PropertyChangedCallbackTests;

public partial class App : Application
{
    private void OnApplicationStartup(object sender, StartupEventArgs e)
    {
        DefaultViewModel viewModel = new();
        MainWindow window = new() { CurrentViewModel = viewModel };

        window.Show();
    }
}