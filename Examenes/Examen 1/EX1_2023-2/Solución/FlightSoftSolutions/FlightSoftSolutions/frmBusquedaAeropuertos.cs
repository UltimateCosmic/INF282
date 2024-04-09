using FlightSoftSolutionsController.DAO;
using FlightSoftSolutionsController.MySQL;
using FlightSoftSolutionsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightSoftSolutions
{
    public partial class frmBusquedaAeropuertos : Form
    {
        private AeropuertoDAO _daoAeropuerto;
        private Aeropuerto _aeropuertoSeleccionado;
        private BindingList<EmpresaComercial> _empresasComerciales;
        private EmpresaComercialDAO _daoEmpresaComercial;
        public frmBusquedaAeropuertos()
        {
            _daoAeropuerto = new AeropuertoMySQL();
            InitializeComponent();
            dgvAeropuertos.AutoGenerateColumns = false;
        }

        public Aeropuerto AeropuertoSeleccionado { get => _aeropuertoSeleccionado; set => _aeropuertoSeleccionado = value; }

        private void dgvAeropuertos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Aeropuerto aeropuerto = (Aeropuerto)dgvAeropuertos.Rows[e.RowIndex].DataBoundItem;
            dgvAeropuertos.Rows[e.RowIndex].Cells[0].Value = aeropuerto.Nombre;
            dgvAeropuertos.Rows[e.RowIndex].Cells[1].Value = aeropuerto.Ciudad.Nombre;
            dgvAeropuertos.Rows[e.RowIndex].Cells[2].Value = aeropuerto.Operadora.Nombre;            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvAeropuertos.DataSource = _daoAeropuerto.listarPorNombre(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            AeropuertoSeleccionado = (Aeropuerto)dgvAeropuertos.CurrentRow.DataBoundItem;
            AeropuertoSeleccionado.EmpresasComerciales = new BindingList<EmpresaComercial>();
            _daoEmpresaComercial = new EmpresaComercialMySQL();
            foreach (EmpresaComercial ec in _daoEmpresaComercial.listarPorIdAeropuerto(AeropuertoSeleccionado.IdAeropuerto))
            {
                AeropuertoSeleccionado.EmpresasComerciales.Add(ec);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
