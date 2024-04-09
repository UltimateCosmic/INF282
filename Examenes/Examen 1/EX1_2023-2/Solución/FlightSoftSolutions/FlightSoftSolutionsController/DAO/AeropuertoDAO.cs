using FlightSoftSolutionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsController.DAO
{
    public interface AeropuertoDAO
    {
        int insertar(Aeropuerto aeropuerto);
        BindingList<Aeropuerto> listarPorNombre(string nombre);
    }
}
