namespace Explosion.ViewModels
{
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        public IExplosionService? ExplosionService;

        [ObservableProperty]
        private string _title = string.Empty;


        public BaseViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService) : this(dialogService, navigationService)
        {
            ExplosionService = explosionService;
        }
    }
}
