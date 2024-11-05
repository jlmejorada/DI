using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Models
{
    public class Cita
    {
        public int Id { get; set; } = 0;
        public string Cliente { get; set; } = "";
        public string Fecha { get; set; } = "";
        public string Hora { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Direccion { get; set; } = "";

        public Cita()
        {
        }
        public Cita(int id, string cliente, string fecha, string hora, string descripcion, string telefono, string direccion)
        {
            Id = id;
            Cliente = cliente;
            Fecha = fecha;
            Hora = hora;
            Descripcion = descripcion;
            Telefono = telefono;
            Direccion = direccion;
        }
    }
}
