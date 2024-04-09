using FlightSoftSolutionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsController.DAO
{
    public interface EmpresaComercialDAO
    {
        BindingList<EmpresaComercial> listarPorNombreCallsign(string nombreCallsign);
        BindingList<EmpresaComercial> listarPorIdAeropuerto(int idAeropuerto);
    }
}
