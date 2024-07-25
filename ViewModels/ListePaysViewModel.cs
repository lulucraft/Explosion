using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Explosion.ViewModels
{
    public partial class ListePaysViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<Context.Models.Pays>? _pays;

        public ListePaysViewModel(IDialogService dialogService, INavigationService navigationService, IExplosionService explosionService, IPaysService paysService) : base(dialogService, navigationService, explosionService, paysService)
        {
            Pays = new ObservableCollection<Context.Models.Pays>([.. paysService.GetPays()]);
        }
    }
}
