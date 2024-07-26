using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.Diagnostics;

namespace Explosion.ViewModels
{
    public partial class AccueilViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        async Task Buttonlisteexplosion() => await NavigationService.GoToAsync("///listeexplosions");

        [RelayCommand]
        async Task Buttonlistepays() => await NavigationService.GoToAsync("///listepays");

        [RelayCommand]
        private void Buttonquitter() => App.Current!.Quit();
    }
}
