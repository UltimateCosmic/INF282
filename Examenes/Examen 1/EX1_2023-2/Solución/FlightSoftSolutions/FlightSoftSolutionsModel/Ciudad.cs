using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class Ciudad
    {
        private int _idCiudad;
        private string _siglas;
        private string _nombre;
        public int IdCiudad { get => _idCiudad; set => _idCiudad = value; }
        public string Siglas { get => _siglas; set => _siglas = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string NombreSiglas { get => _nombre + " (" + _siglas + ")"; }
    }
}
