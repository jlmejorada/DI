using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio02.Models
{
    /// <summary>
    /// Clase persona
    /// </summary>
    public class ClsPersona: INotifyPropertyChanged
    {
        private string nombre;

        public ClsPersona()
        {
            Nombre = "Jose";
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }

        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
