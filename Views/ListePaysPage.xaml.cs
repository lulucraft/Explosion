namespace Explosion.Views
{
    public partial class ListePaysPage : ContentPage
    {
        public ListePaysPage(ListePaysViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Title = "Liste des pays";
            BindingContext = viewModel;
            SetBinding(Page.TitleProperty, new Binding(nameof(ListePaysViewModel.Title)));
        }
    }
}
