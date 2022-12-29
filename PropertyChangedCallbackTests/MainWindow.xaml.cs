using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace PropertyChangedCallbackTests;

public partial class MainWindow : Window
{
    public ObservableObject? CurrentViewModel { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        DataContext = this;
    }
}