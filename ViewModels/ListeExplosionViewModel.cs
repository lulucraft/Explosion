using System.Collections.ObjectModel;

namespace Explosion.ViewModels
{
    public partial class ListeExplosionViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Context.Models.Explosion>? _explosions;

        public ListeExplosionViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService) : base(dialogService, navigationService, explosionService)
        {
            Explosions = new ObservableCollection<Context.Models.Explosion>([.. explosionService.GetExplosions()]);//_dbContext.Explosions.Include(e => e.IdSiteNavigation)
        }

        [RelayCommand]
        private Task AfficherExplosionAsync(Context.Models.Explosion explosion) => NavigationService.GoToAsync("afficherexplosion", explosion);
    }
}
