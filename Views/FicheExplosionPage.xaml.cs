namespace Explosion.Views
{
    public partial class FicheExplosionPage : ContentPage
    {
        public FicheExplosionPage(FicheExplosionViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Fiche explosion";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(FicheExplosionViewModel.Title)));
        }
    }
}
