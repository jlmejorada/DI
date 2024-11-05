using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlacasSolares.DAL;
using PlacasSolares.Models;

namespace PlacasSolares.ViewModel
{
    public class ListadoCitasVM
    {
        private ObservableCollection<Cita> citas = Listado.getCitas();

        public ObservableCollection<Cita> Citas { get { return citas; } }
    }
}
