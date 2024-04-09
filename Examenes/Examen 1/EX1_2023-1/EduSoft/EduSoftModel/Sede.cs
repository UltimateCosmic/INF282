using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class Sede
    {
        private int _idSede;
        private BindingList<ProgramaAcademico> _programasAcademicos;
        private TipoSede _tipoSede;
        private Ejecutivo _ejecutivo;
        private string _nombre;
        private string _direccion;
        private DateTime _fechaInauguracion;
        private int _cantidadAulas;
        private int _aforoTotal;
        private byte[] _foto;
        private bool _tieneAuditorio;
        private bool _tieneBiblioteca;
        private bool _tieneEstacionamiento;
        private bool _tieneSalasEstudio;
        private bool _tieneCafeteria;
        private bool _activo;

        public int IdSede { get => _idSede; set => _idSede = value; }
        public BindingList<ProgramaAcademico> ProgramasAcademicos { get => _programasAcademicos; set => _programasAcademicos = value; }
        public TipoSede TipoSede { get => _tipoSede; set => _tipoSede = value; }
        public Ejecutivo Ejecutivo { get => _ejecutivo; set => _ejecutivo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public DateTime FechaInauguracion { get => _fechaInauguracion; set => _fechaInauguracion = value; }
        public int CantidadAulas { get => _cantidadAulas; set => _cantidadAulas = value; }
        public int AforoTotal { get => _aforoTotal; set => _aforoTotal = value; }
        public bool TieneAuditorio { get => _tieneAuditorio; set => _tieneAuditorio = value; }
        public bool TieneBiblioteca { get => _tieneBiblioteca; set => _tieneBiblioteca = value; }
        public bool TieneEstacionamiento { get => _tieneEstacionamiento; set => _tieneEstacionamiento = value; }
        public bool TieneSalasEstudio { get => _tieneSalasEstudio; set => _tieneSalasEstudio = value; }
        public bool TieneCafeteria { get => _tieneCafeteria; set => _tieneCafeteria = value; }
        public bool Activo { get => _activo; set => _activo = value; }
        public byte[] Foto { get => _foto; set => _foto = value; }
    }
}
