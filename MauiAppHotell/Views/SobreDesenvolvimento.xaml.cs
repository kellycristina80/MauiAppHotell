using Microsoft.Maui.Controls;

namespace MauiAppHotell.Views
{
    public partial class SobreDesenvolvimento : ContentPage
    {
        public SobreDesenvolvimento()
        {
            InitializeComponent();
        }

        private void Sair_Clicked(object sender, EventArgs e)
        {
            // Exemplo: Fechar a página ou navegar para outra
            Navigation.PopAsync();
        }
    }
}