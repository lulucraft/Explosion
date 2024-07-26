namespace Explosion.ViewModels
{
    [QueryProperty(nameof(Context.Models.Explosion), "data")]
    public partial class FicheExplosionViewModel(IDialogService dialogService, INavigationService navigationService) : BaseViewModel(dialogService, navigationService)
    {
        [ObservableProperty]
        private Context.Models.Explosion _explosion = new();

        [RelayCommand]
        private Task RetourAsync() => NavigationService.GoBackAsync();
    }
}
