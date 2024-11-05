namespace PlacasSolares.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprueba que se introdducen los dos campos y pasa al listado de citas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            var nombre = usuarioEntry.Text;
            var contrasena = contrasenaEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(contrasena))
            {
                await DisplayAlert("Error", "Tienes que poner nombre y contraseña", "OK");
            }
            else
            {
                await Navigation.PushAsync(new ListadoCitas());
            }
        }
    }

}
