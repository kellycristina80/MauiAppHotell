using MauiAppHotell.Models;

namespace MauiAppHotell.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        private Evento evento;

        public CadastroEventoPage()
        {
            InitializeComponent();
            evento = new Evento
            {
                DataInicio = DateTime.Today,
                DataTermino = DateTime.Today
            };
            BindingContext = evento;
        }

        private async void OnSalvarEventoClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Evento Salvo", $"Evento {evento.Nome} cadastrado com sucesso!\n" +
                                               $"Duração: {evento.DuracaoEmDias} dias\n" +
                                               $"Custo Total: R$ {evento.CustoTotal:F2}", "OK");
        }
        private async void OnVerResumoClicked(object sender, EventArgs e)
        {
            var duracao = evento.Duracao;
            await DisplayAlert("Resumo do Evento",
                $"Nome: {evento.Nome}\n" +
                $"Local: {evento.Local}\n" +
                $"Início: {evento.DataInicio:dd/MM/yyyy}\n" +
                $"Término: {evento.DataTermino:dd/MM/yyyy}\n" +
                $"Duração: {duracao.Days + 1} dias ({duracao.TotalHours:F1} horas)\n" +
                $"Participantes: {evento.NumeroParticipantes}\n" +
                $"Custo Total: R$ {evento.CustoTotal:F2}",
                "Fechar");
        }

    }
}
