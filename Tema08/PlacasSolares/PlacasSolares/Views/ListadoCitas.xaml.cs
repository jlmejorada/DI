using PlacasSolares.DAL;
using PlacasSolares.Models;
using System.Collections.ObjectModel;

namespace PlacasSolares.Views;

public partial class ListadoCitas : ContentPage
{
    public ListadoCitas()
    {
        InitializeComponent();

        ObservableCollection<Cita> citas = Listado.getCitas();
        BindingContext = this;
    }

    /// <summary>
    /// Vuelve a la pantalla anterior
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}