using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.DAO
{
    public interface ProgramaAcademicoDAO
    {
        BindingList<ProgramaAcademico> listarPorNombreClave(String nombreClave);
        BindingList<ProgramaAcademico> listarPorIdSede(int idSede);
    }
}
