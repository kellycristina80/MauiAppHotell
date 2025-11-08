using MauiAppHotell.Models;

namespace MauiAppHotell.Views;

public partial class HospedagemContratada : ContentPage
{
    private object labelResumo;

    public HospedagemContratada (Quartos reserva)
    {
        InitializeComponent();
        double total = reserva.ValorDiariaAdulto +
                      reserva.ValorDiariaCrianca;

        labelResumo.Text = $"""
            Quarto: {reserva.Descricao}
            Valor da diária adulto: R$ {reserva.ValorDiariaAdulto}
            Valor da diária criança: R$ {reserva.ValorDiariaCrianca}
            Valor total: R$ {total}
            """;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS", ex.Message, "OK");
        }
    }
}