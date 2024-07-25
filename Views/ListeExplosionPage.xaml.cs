namespace Explosion.Views
{
    public partial class ListeExplosionPage : ContentPage
    {
        public ListeExplosionPage(ListeExplosionViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Liste des explosions";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(ListeExplosionViewModel.Title)));
        }
    }
}
