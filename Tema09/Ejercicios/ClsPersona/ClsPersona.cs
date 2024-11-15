using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClsPersona
{
    /// <summary>
    /// Clase persona
    /// </summary>
    public class ClsPersona 
    {
        #region atributos
        private string nombre;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region constructores
        public ClsPersona()
        {
            this.nombre = "Jose";
        }


        public ClsPersona(string nombre)
        {
            this.nombre = nombre;
        }

        #endregion
    }
}
