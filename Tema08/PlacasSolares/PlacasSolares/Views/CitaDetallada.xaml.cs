namespace PlacasSolares.Views;

public partial class CitaDetallada : ContentPage
{
	public CitaDetallada()
	{
		InitializeComponent();
	}


    /// <summary>
    /// Vuelve a la pantalla de las listas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void VolvemosListas(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListadoCitas());
    }
}