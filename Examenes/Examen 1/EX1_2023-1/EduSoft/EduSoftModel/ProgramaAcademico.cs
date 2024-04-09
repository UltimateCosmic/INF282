using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class ProgramaAcademico
    {
        private int _idProgramaAcademico;
        private char _tipoProgramaAcademico;
        private string _nombre;
        private string _clave;
        public int IdProgramaAcademico { get => _idProgramaAcademico; set => _idProgramaAcademico = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Clave { get => _clave; set => _clave = value; }
        public char TipoProgramaAcademico { get => _tipoProgramaAcademico; set => _tipoProgramaAcademico = value; }
    }
}
