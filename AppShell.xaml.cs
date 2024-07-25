namespace Explosion
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
            Routing.RegisterRoute("afficherexplosion", typeof(FicheExplosionPage));
            Routing.RegisterRoute("editionpays", typeof(EditionPaysPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}
