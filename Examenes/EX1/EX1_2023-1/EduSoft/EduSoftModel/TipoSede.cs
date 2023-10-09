using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class TipoSede
    {
        private int _idTipoSede;
        private string _nombre;
        private bool _activo;
        public int IdTipoSede { get => _idTipoSede; set => _idTipoSede = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
