using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSoftModel
{
    public class Local
    {
        private int _idLocal;
        private string _nombre;
        private string _direccion;
        private DateTime _fechaConstruccion;
        private int _aforo;
        private EstiloArquitectonico _estiloArquitectonico;
        private bool _tienePalco;
        private bool _tieneProyector;
        private bool _tieneVestibulo;
        private string _resenha;
        private byte[] _foto;
        private byte[] _plano;
        private bool _activo;

        public int IdLocal { get => _idLocal; set => _idLocal = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public DateTime FechaConstruccion { get => _fechaConstruccion; set => _fechaConstruccion = value; }
        public int Aforo { get => _aforo; set => _aforo = value; }
        public EstiloArquitectonico EstiloArquitectonico { get => _estiloArquitectonico; set => _estiloArquitectonico = value; }
        public bool TienePalco { get => _tienePalco; set => _tienePalco = value; }
        public bool TieneProyector { get => _tieneProyector; set => _tieneProyector = value; }
        public bool TieneVestibulo { get => _tieneVestibulo; set => _tieneVestibulo = value; }
        public string Resenha { get => _resenha; set => _resenha = value; }
        public byte[] Foto { get => _foto; set => _foto = value; }
        public byte[] Plano { get => _plano; set => _plano = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public string NombreEstiloArq { get => _estiloArquitectonico.Nombre; }
    }
}