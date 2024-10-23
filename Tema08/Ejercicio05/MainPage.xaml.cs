using Ejercicio05.Modelos.DAL;
using System.Collections.ObjectModel;

namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {


     
        public MainPage()
        {
            InitializeComponent();
            PersonaListView.ItemsSource = lista.listadoPersonas();

        }


    }

}
