using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftModel
{
    public class Productora
    {
        private int _idProductora;
        private string _nombre;
        private byte[] _logo;
        private int _R;
        private int _G;
        private int _B;
        public int IdProductora { get => _idProductora; set => _idProductora = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public byte[] Logo { get => _logo; set => _logo = value; }
        public int R { get => _R; set => _R = value; }
        public int G { get => _G; set => _G = value; }
        public int B { get => _B; set => _B = value; }
    }
}