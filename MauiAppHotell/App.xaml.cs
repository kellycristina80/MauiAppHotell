using Microsoft.Maui; // Adiciona o namespace para Window e IActivationState
using Microsoft.Maui.Controls; // Adiciona o namespace para Application

namespace MauiAppHotell
{
    public partial class App : Application
    {
        public List<Models.Quartos> listaQuartos = new List<Models.Quartos>()
        {
            new Models.Quartos()
            {
                Descricao = "Quarto Standard",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 55.0
            },
            new Models.Quartos()
            {
                Descricao = "Quarto Deluxe",
                ValorDiariaAdulto = 200.0,
                ValorDiariaCrianca = 110.0
            },
            new Models.Quartos()
            {
                Descricao = "Suíte Executiva",
                ValorDiariaAdulto = 300.0,
                ValorDiariaCrianca = 150.0
            }
        };
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
