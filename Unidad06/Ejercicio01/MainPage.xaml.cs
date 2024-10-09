
namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        // Inicializamos el botón en falso
        Boolean existeBoton3 = false;

        public MainPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Funcioón que crea el botón 3 y lo añade al layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuandoClicasBoton2(object sender, EventArgs e)
        {
            if (!existeBoton3)
            {
                Button boton3 = new Button
                {
                    Text = "Botón3",
                    BackgroundColor = Colors.BlueViolet,
                    FontAttributes=FontAttributes.Bold,
                    FontFamily= "Verdana",
                    BorderColor=Colors.Black,
                    BorderWidth=3,
                    MaximumWidthRequest = 200,
                    MaximumHeightRequest = 70,
                    Margin = 5
                };

                boton3.Clicked += cuandoClicasBoton3;
                botones.Children.Add(boton3);
                existeBoton3 = true;

            }



        }

        /// <summary>
        /// Funcion que cambia el texto del boton 2 y borra el boton 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cuandoClicasBoton3(object sender, EventArgs e)
        {
            boton2.Text = "Crear controles en tiempo de ejecución mola";
            botones.Children.Remove(boton1);
        }

    }

}
