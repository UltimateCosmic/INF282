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
    public partial class frmBusquedaOperadoras : Form
    {
        private OperadoraDAO _daoOperadora;
        private Operadora _operadoraSeleccionada;
        public frmBusquedaOperadoras()
        {
            _daoOperadora = new OperadoraMySQL();
            InitializeComponent();
            dgvOperadoras.AutoGenerateColumns = false;
        }

        public Operadora OperadoraSeleccionada { get => _operadoraSeleccionada; set => _operadoraSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvOperadoras.DataSource = _daoOperadora.listarPorNombre(txtNombre.Text);
        }

        private void dgvOperadoras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Operadora operadora = (Operadora)dgvOperadoras.Rows[e.RowIndex].DataBoundItem;
            dgvOperadoras.Rows[e.RowIndex].Cells[0].Value = operadora.Nombre;
            if  (operadora.OfreceSoporteLogistico)
                dgvOperadoras.Rows[e.RowIndex].Cells[1].Value = "Si";
            else
                dgvOperadoras.Rows[e.RowIndex].Cells[1].Value = "No";
            if (operadora.OfreceAsistenciaNavegacion)
                dgvOperadoras.Rows[e.RowIndex].Cells[2].Value = "Si";
            else
                dgvOperadoras.Rows[e.RowIndex].Cells[2].Value = "No";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OperadoraSeleccionada = (Operadora)dgvOperadoras.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
