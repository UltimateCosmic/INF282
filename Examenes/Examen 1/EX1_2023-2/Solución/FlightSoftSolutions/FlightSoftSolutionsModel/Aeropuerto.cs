using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class Aeropuerto
    {
        private int _idAeropuerto;
        private Ciudad _ciudad;
        private Operadora _operadora;
        private BindingList<EmpresaComercial> _empresasComerciales;
        private string _nombre;
        private string _direccion;
        private int _anhoFundacion;
        private double _costoConstruccion;
        private TipoAeropuerto _tipoAeropuerto;
        private bool _tieneSalaVIP;
        private bool _tieneWiFi;
        private bool _tieneSistemaGestionEquipaje;
        private byte[] _foto;
        private bool _activo;

        public int IdAeropuerto { get => _idAeropuerto; set => _idAeropuerto = value; }
        public Ciudad Ciudad { get => _ciudad; set => _ciudad = value; }
        public Operadora Operadora { get => _operadora; set => _operadora = value; }
        public BindingList<EmpresaComercial> EmpresasComerciales { get => _empresasComerciales; set => _empresasComerciales = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int AnhoFundacion { get => _anhoFundacion; set => _anhoFundacion = value; }
        public double CostoConstruccion { get => _costoConstruccion; set => _costoConstruccion = value; }
        public TipoAeropuerto TipoAeropuerto { get => _tipoAeropuerto; set => _tipoAeropuerto = value; }
        public bool TieneSalaVIP { get => _tieneSalaVIP; set => _tieneSalaVIP = value; }
        public bool TieneWiFi { get => _tieneWiFi; set => _tieneWiFi = value; }
        public bool TieneSistemaGestionEquipaje { get => _tieneSistemaGestionEquipaje; set => _tieneSistemaGestionEquipaje = value; }
        public byte[] Foto { get => _foto; set => _foto = value; }
        public bool Activo { get => _activo; set => _activo = value; }
    }
}