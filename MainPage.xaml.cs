namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        // Navega para a nova tela "Sobre"
        await Navigation.PushAsync(new Sobre());
    }
}
