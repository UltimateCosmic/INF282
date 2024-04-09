using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSoftModel
{
    public class EstiloArquitectonico
    {
        private int _idEstiloArquitectonico;
        private string _nombre;
        private bool _activo;
        public int IdEstiloArquitectonico { get => _idEstiloArquitectonico; set => _idEstiloArquitectonico = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
