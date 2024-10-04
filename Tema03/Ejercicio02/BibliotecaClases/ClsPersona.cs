using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace BibliotecaClases
{
    public class ClsPersona
    {
        #region: Atributos
            private String nombre = "";
        #endregion

        #region: Constructores
            public ClsPersona()
            {
                this.nombre = "";
            }

            public ClsPersona(string nombre)
            {
                this.nombre = nombre;
            }
        #endregion

        #region: Getters y Setters
            public String Nombre
            {
                get { return this.nombre; }
                set { nombre = value; }
            }
        #endregion
    }
}
