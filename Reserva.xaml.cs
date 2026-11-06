namespace AppHotel;

public partial class Reserva : ContentPage
{
    public Reserva()
    {
        InitializeComponent();
    }

    private async void OnConfirmarClicked(object sender, EventArgs e)
    {
        // Exibe uma mensagem de confirmação para o usuário
        await DisplayAlert("Sucesso", "Reserva confirmada com sucesso!", "OK");
        
        // Retorna para a tela principal
        await Navigation.PopAsync();
    }
}
