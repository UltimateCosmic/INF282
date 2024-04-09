using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSoftModel
{
    public class Pelicula
    {
        private int _idPelicula;
        private Genero _genero;
        private Productora _productora;
        private string _nombre;
        private DateTime _fechaEstreno;
        private bool _formatoDoblada;
        private bool _formatoSubtitulada;
        private bool _formatoXtreme;
        private bool _formato3D;
        private double _costoProduccion;
        private string _sinopsis;
        private byte[] _portada;
        private bool _activa;

        public int IdPelicula { get => _idPelicula; set => _idPelicula = value; }
        public Genero Genero { get => _genero; set => _genero = value; }
        public Productora Productora { get => _productora; set => _productora = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaEstreno { get => _fechaEstreno; set => _fechaEstreno = value; }
        public bool FormatoDoblada { get => _formatoDoblada; set => _formatoDoblada = value; }
        public bool FormatoSubtitulada { get => _formatoSubtitulada; set => _formatoSubtitulada = value; }
        public bool FormatoXtreme { get => _formatoXtreme; set => _formatoXtreme = value; }
        public bool Formato3D { get => _formato3D; set => _formato3D = value; }
        public double CostoProduccion { get => _costoProduccion; set => _costoProduccion = value; }
        public string Sinopsis { get => _sinopsis; set => _sinopsis = value; }
        public byte[] Portada { get => _portada; set => _portada = value; }
        public bool Activa { get => _activa; set => _activa = value; }
    }
}
