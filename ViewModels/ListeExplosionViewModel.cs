using Explosion.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;

namespace Explosion.ViewModels
{
    public partial class ListeExplosionViewModel : BaseViewModel
    {
        private readonly TpExplosionContext _dbContext;

        [ObservableProperty]
        private ObservableCollection<Explosion.Context.Models.Explosion>? _explosions;

        public ListeExplosionViewModel(IDialogService dialogService, INavigationService navigationService) : base(dialogService, navigationService)
        {
            // Remplacez cela par votre logique de récupération de données à partir de Explosion.Context
            using var context = new TpExplosionContext();
            _dbContext = context;
            //Explosions = new ObservableCollection<Explosion.Context.Models.Explosion>(context.Explosions.ToList());
            LoadData();
        }

        private void LoadData()
        {
            Explosions = new ObservableCollection<Explosion.Context.Models.Explosion>(_dbContext.Explosions.ToList());
        }
    }
}
