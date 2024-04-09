using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class TiendaRetail : EmpresaComercial
    {
        private int _cantidadEmpleados;
        private bool _activa;

        public int CantidadEmpleados { get => _cantidadEmpleados; set => _cantidadEmpleados = value; }
        public bool Activa { get => _activa; set => _activa = value; }
    }
}
