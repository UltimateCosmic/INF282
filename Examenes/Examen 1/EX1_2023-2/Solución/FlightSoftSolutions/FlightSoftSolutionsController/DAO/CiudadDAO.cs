﻿using FlightSoftSolutionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsController.DAO
{
    public interface CiudadDAO
    {
        BindingList<Ciudad> listarTodas();
    }
}
