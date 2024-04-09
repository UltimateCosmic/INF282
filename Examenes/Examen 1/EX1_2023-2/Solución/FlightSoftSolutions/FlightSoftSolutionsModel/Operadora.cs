using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSoftSolutionsModel
{
    public class Operadora : Empresa
    {
        private bool _ofreceSoporteLogistico;
        private bool _ofreceAsistenciaNavegacion;
        private bool _activa;

        public bool OfreceSoporteLogistico { get => _ofreceSoporteLogistico; set => _ofreceSoporteLogistico = value; }
        public bool OfreceAsistenciaNavegacion { get => _ofreceAsistenciaNavegacion; set => _ofreceAsistenciaNavegacion = value; }
        public bool Activa { get => _activa; set => _activa = value; }
    }
}
