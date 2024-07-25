using System.Collections.ObjectModel;

namespace Explosion.ViewModels
{
    public partial class ListeExplosionViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Context.Models.Explosion>? _explosions;

        [ObservableProperty]
        private string _searchText = string.Empty;

        [ObservableProperty]
        private ObservableCollection<Context.Models.Explosion> _searchResults = [];

        public ListeExplosionViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService, IPaysService paysService) : base(dialogService, navigationService, explosionService, paysService)
        {
            LoadExplosions(explosionService);
        }

        private void LoadExplosions(IExplosionService explosionService)
        {
            Explosions = new ObservableCollection<Context.Models.Explosion>([.. explosionService.GetExplosions()]);//_dbContext.Explosions.Include(e => e.IdSiteNavigation)
        }

        [RelayCommand]
        private Task AfficherExplosionAsync(Context.Models.Explosion explosion) => NavigationService.GoToAsync("afficherexplosion", explosion);

        [RelayCommand]
        private void Search()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                // Filtrage des résultats
                /*SearchResults = new ObservableCollection<Context.Models.Explosion>(results.Where(item => item.Contains(SearchText, StringComparison.InvariantCultureIgnoreCase)));*/
            }
            else
            {
                SearchResults.Clear();
            }
        }
    }
}
