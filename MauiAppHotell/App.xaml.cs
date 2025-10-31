using Microsoft.Maui; // Adiciona o namespace para Window e IActivationState
using Microsoft.Maui.Controls; // Adiciona o namespace para Application

namespace MauiAppHotell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Height = 600;
            window.Width = 400;
            return window;
        }

    }
}
