namespace Explosion.ViewModels
{
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        public IExplosionService? ExplosionService;

        public IPaysService? PaysService;

        [ObservableProperty]
        private string _title = string.Empty;


        public BaseViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService, IPaysService paysService) : this(dialogService, navigationService)
        {
            ExplosionService = explosionService;
            PaysService = paysService;
        }
    }
}
