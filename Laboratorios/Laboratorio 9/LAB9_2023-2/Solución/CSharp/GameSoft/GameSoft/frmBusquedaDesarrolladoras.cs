using GameSoft.ServicioWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoft
{
    public partial class frmBusquedaDesarrolladoras : Form
    {
        private ServicioWSClient _daoServicioWS;
        private desarrolladora _desarrolladoraSeleccionada;

        public desarrolladora DesarrolladoraSeleccionada { get => _desarrolladoraSeleccionada; set => _desarrolladoraSeleccionada = value; }


        public frmBusquedaDesarrolladoras()
        {
            _daoServicioWS = new ServicioWSClient();
            InitializeComponent();
            dgvDesarrolladoras.AutoGenerateColumns = false;
        }
        private void dgvDesarrolladoras_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            desarrolladora desarrolladora = (desarrolladora)dgvDesarrolladoras.Rows[e.RowIndex].DataBoundItem;
            dgvDesarrolladoras.Rows[e.RowIndex].Cells[0].Value = desarrolladora.idDesarrolladora;
            dgvDesarrolladoras.Rows[e.RowIndex].Cells[1].Value = desarrolladora.nombre;
            dgvDesarrolladoras.Rows[e.RowIndex].Cells[2].Value = desarrolladora.pais;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDesarrolladoras.DataSource = _daoServicioWS.listarDesarrolladorasPorNombre(txtNombre.Text).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DesarrolladoraSeleccionada = (desarrolladora)dgvDesarrolladoras.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
