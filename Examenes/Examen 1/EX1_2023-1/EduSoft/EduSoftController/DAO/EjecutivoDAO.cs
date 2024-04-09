using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSoftController.DAO
{
    public interface EjecutivoDAO
    {
        BindingList<Ejecutivo> listarPorNombreDNI(String nombreDNI);
    }
}
