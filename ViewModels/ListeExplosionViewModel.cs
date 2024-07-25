using System.Collections.ObjectModel;

namespace Explosion.ViewModels
{
    public partial class ListeExplosionViewModel : BaseViewModel
    {
        private readonly IExplosionService _explosionService;

        [ObservableProperty]
        private ObservableCollection<Context.Models.Explosion>? _explosions;

        public ListeExplosionViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService) : base(dialogService, navigationService, explosionService)
        {
            _explosionService = explosionService;
            LoadData();
        }

        private void LoadData()
        {
            Explosions = new ObservableCollection<Context.Models.Explosion>([.. _explosionService.GetExplosions()]);//_dbContext.Explosions.Include(e => e.IdSiteNavigation)
        }
    }
}
