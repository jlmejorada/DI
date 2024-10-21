using Ejercicio05Ent;
using System.Collections.ObjectModel;

namespace Ejercicio05
{
    public partial class MainPage : ContentPage
    {


        ObservableCollection <clsPersona> personas = new ObservableCollection<clsPersona>();
        public ObservableCollection<clsPersona> Persona { get { return personas; } }
        public MainPage()
        {
            InitializeComponent();
            personas.Add(new clsPersona() { Nombre = "Jose Luis", Apellido = "Mejorada Marín" });
            personas.Add(new clsPersona() { Nombre = "Marta", Apellido = "Rquejo Merino",});
            personas.Add(new clsPersona() { Nombre = "Ruben", Apellido = "García Barquero" });
            PersonaListView.ItemsSource = personas;
        }


    }

}
