using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class Aerolinea : EmpresaComercial
    {
        private int _numeroAviones;
        private bool _activa;

        public int NumeroAviones { get => _numeroAviones; set => _numeroAviones = value; }
        public bool Activa { get => _activa; set => _activa = value; }
    }
}
