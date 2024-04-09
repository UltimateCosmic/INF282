using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class Empresa
    {
        private int _idEmpresa;
        private string _nombre;

        public int IdEmpresa { get => _idEmpresa; set => _idEmpresa = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
