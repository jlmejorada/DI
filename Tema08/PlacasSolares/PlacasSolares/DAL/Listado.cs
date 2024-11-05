using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlacasSolares.Models;

namespace PlacasSolares.DAL
{
    public class Listado
    {
        public static ObservableCollection<Cita> getCitas()
        {
            return new ObservableCollection<Cita>{
                new Cita(1, "Sofía", "10/11/2024", "09:00", "Reunión inicial con el cliente para evaluar necesidades del cliente.", "555-1234", "Av. Sol Naciente 123"),
                new Cita(2, "Luis", "12/11/2024", "10:30", "Presentación del plan de instalación de paneles solares.", "555-5678", "Calle Verde 456"),
                new Cita(3, "Marta", "15/11/2024", "11:00", "Presentación del plan de instalación de paneles solares.", "555-9101", "Plaza del Sol 789"),
                new Cita(4, "Diego", "19/11/2024", "14:00", "Evaluación técnica del sitio y requisitos eléctricos.", "555-2345", "Camino Solar 1011"),
                new Cita(5, "Elena", "25/11/2024", "15:30", "Reunión inicial con el cliente para evaluar necesidades del cliente.", "555-3456", "Paseo de la Energía 1213")
            };
        }
    }
}
