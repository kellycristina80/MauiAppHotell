using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotell.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesAPP;
        public ContratacaoHospedagem()
        {
            InitializeComponent();
            PropriedadesAPP = (App)Application.Current;
            pck_quarto.ItemsSource = PropriedadesAPP.listaQuartos;
            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);
            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var hospedagem = new Models.Hospedagem()
            {
                QntAdultos = (int)stp_adultos.Value,
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,
                QntCriancas = (int)stp_criancas.Value,
                QuartoSelecionado = (Models.Quartos)pck_quarto.SelectedItem
            };
            try
            {
                Navigation.PushAsync(new HospedagemContratada() { BindingContext=hospedagem});
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!", ex.Message, "OK");
            }
        }
        private void Sobre_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new SobreDesenvolvimento());
            }
            catch (Exception ex)
            {
                DisplayAlert("OPS!", ex.Message, "OK");
            }
        }


        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;
            DateTime data_selecionada_checkin = elemento.Date;
            dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
            dtpck_checkout.MaximumDate = data_selecionada_checkin.AddSeconds(6);


        }
        private async void CadastroEvento_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroEventoPage());
        }


    }
}