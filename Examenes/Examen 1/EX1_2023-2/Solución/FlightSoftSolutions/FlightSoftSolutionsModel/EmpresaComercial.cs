using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class EmpresaComercial : Empresa
    {
        private string _callsign;
        public string Callsign { get => _callsign; set => _callsign = value; }
    }
}
