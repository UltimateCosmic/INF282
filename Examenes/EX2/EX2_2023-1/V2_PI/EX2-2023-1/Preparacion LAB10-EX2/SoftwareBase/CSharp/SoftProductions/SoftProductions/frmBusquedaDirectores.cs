using SoftProductions.SoftProductionsWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftProductions
{
    public partial class frmBusquedaDirectores : Form
    {
        private SoftProductionsWSClient _daoSoftProductionsWS;
        private director _director;

        public director Director { get => _director; set => _director = value; }

        public frmBusquedaDirectores()
        {
            _daoSoftProductionsWS = new SoftProductionsWSClient();
            InitializeComponent();
            dgvDirectores.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDirectores.DataSource = _daoSoftProductionsWS.listarTodosDirectores(txtNombre.Text);
        }

        private void dgvDirectores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            director directorAux = (director)dgvDirectores.Rows[e.RowIndex].DataBoundItem;
            dgvDirectores.Rows[e.RowIndex].Cells[0].Value = directorAux.nombreDirector + " " + directorAux.apellidoDirector;
            dgvDirectores.Rows[e.RowIndex].Cells[1].Value = directorAux.nacionalidad;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDirectores.CurrentRow.Index != -1)
            {
                Director = (director)dgvDirectores.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
