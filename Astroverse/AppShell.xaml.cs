using Astroverse.Views;

namespace Astroverse
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(PlanetariumPage), typeof(PlanetariumPage));
        }
    }
}
