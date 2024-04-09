using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftModel
{
    public class Curso : ProgramaAcademico
    {
        private int _cantidadCreditos;
        private DateTime _fechaInicio;
        public int CantidadCreditos { get => _cantidadCreditos; set => _cantidadCreditos = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
    }
}
