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
    public partial class frmBusquedaEmpresasComerciales : Form
    {
        private EmpresaComercialDAO _daoEmpresaComercial;
        private EmpresaComercial _empresaComercialSeleccionada;
        public frmBusquedaEmpresasComerciales()
        {
            _daoEmpresaComercial = new EmpresaComercialMySQL();
            InitializeComponent();
            dgvEmpresasComerciales.AutoGenerateColumns = false;
        }

        public EmpresaComercial EmpresaComercialSeleccionada { get => _empresaComercialSeleccionada; set => _empresaComercialSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmpresasComerciales.DataSource = _daoEmpresaComercial.listarPorNombreCallsign(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EmpresaComercialSeleccionada = (EmpresaComercial)dgvEmpresasComerciales.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }

        private void dgvEmpresasComerciales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            EmpresaComercial empresaComercial = (EmpresaComercial)dgvEmpresasComerciales.Rows[e.RowIndex].DataBoundItem;
            if (typeof(Aerolinea).IsInstanceOfType(empresaComercial))
            {
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[0].Value = "Aerolinea";
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[3].Value = ((Aerolinea)empresaComercial).NumeroAviones;
            }
            else if (typeof(TiendaRetail).IsInstanceOfType(empresaComercial))
            {
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[0].Value = "Tienda Retail";
                dgvEmpresasComerciales.Rows[e.RowIndex].Cells[3].Value = ((TiendaRetail)empresaComercial).CantidadEmpleados;
            }
            dgvEmpresasComerciales.Rows[e.RowIndex].Cells[1].Value = empresaComercial.Callsign;
            dgvEmpresasComerciales.Rows[e.RowIndex].Cells[2].Value = empresaComercial.Nombre;

        }
    }
}
