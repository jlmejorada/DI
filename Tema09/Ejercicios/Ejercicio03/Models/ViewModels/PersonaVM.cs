using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ClsPersona;

namespace Ejercicio03.Models.ViewModels
{
    internal class NombreVM: INotifyPropertyChanged
    {
        //private Persona _persona;
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                INotifyPropertyChanged("Persona");
            }
        }

        public ClsPersona Persona
        {
            get { return new ClsPersona(nombre); }
        }


        #region Notify
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
