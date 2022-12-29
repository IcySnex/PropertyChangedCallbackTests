using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PropertyChangedCallbackTests_WinUi.ViewModels;

public partial class DefaultViewModel : ObservableObject
{
    [ObservableProperty]
    bool isChecked = false;

    partial void OnIsCheckedChanged(bool value)
    {
        Debug.WriteLine($"[ViewModel-OnIsCheckedChanged]  Property has changed. IsChecked: {IsChecked}");
    }


    [RelayCommand]
    async Task VerificationAsync()
    {
        Debug.WriteLine($"[ViewModel-VerificationAsync]  VerificationCommand got invoked. IsChecked: {IsChecked}");

        // Some async actions with 'IsChecked'
        await Task.Delay(100);
    }
}