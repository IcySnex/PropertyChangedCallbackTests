using Microsoft.UI.Xaml.Controls;
using PropertyChangedCallbackTests_WinUi.ViewModels;

namespace PropertyChangedCallbackTests_WinUi.Views;

public sealed partial class DefaultView : Page
{
    DefaultViewModel viewModel = new();

    public DefaultView()
    {
        InitializeComponent();
    }
}