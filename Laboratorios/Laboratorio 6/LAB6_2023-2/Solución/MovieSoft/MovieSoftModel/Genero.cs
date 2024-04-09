using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftModel
{
    public class Genero
    {
        private int _idGenero;
        private string _nombre;
        private bool _activo;
        public int IdGenero { get => _idGenero; set => _idGenero = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}
