using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class Ejecutivo
    {
        private int _idEjecutivo;
        private string _DNI;
        private string _nombre;
        private string _apellidoPaterno;
        public int IdEjecutivo { get => _idEjecutivo; set => _idEjecutivo = value; }
        public string DNI { get => _DNI; set => _DNI = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string ApellidoPaterno { get => _apellidoPaterno; set => _apellidoPaterno = value; }
    }
}
