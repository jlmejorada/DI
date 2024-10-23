using Ejercicio05.Modelos.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Modelos.DAL
{
    class lista{
        
        public static ObservableCollection<clsPersona> listadoPersonas() {

            ObservableCollection<clsPersona> personas = new ObservableCollection<clsPersona> {

                 new clsPersona() { Nombre = "Jose Luis", Apellido = "Mejorada Marín" },
                 new clsPersona() { Nombre = "Marta", Apellido = "Requejo Merino", },
                 new clsPersona() { Nombre = "Ruben", Apellido = "García Barquero" },
                 new clsPersona() { Nombre = "Ana", Apellido = "García López" },
                 new clsPersona() { Nombre = "Juan", Apellido = "Martínez González" },
                 new clsPersona() { Nombre = "Laura", Apellido = "Fernández Pérez" },
                 new clsPersona() { Nombre = "Pedro", Apellido = "Sánchez Rodríguez" },
                 new clsPersona() { Nombre = "Carmen", Apellido = "López Jiménez" },
                 new clsPersona() { Nombre = "Luis", Apellido = "Hernández Muñoz" },
                 new clsPersona() { Nombre = "María", Apellido = "Romero Morales" }

             };
             return personas;

        }
    }
}
