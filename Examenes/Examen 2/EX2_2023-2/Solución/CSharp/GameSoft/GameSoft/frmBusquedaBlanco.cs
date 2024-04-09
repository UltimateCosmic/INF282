using GameSoft.ServicioWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoft
{
    public partial class frmBusquedaBlanco : Form
    {
        private ServicioWebClient _daoServicioWeb;
        private blanco _blanco;
        public blanco Blanco { get => _blanco; set => _blanco = value; }

        public frmBusquedaBlanco()
        {
            _daoServicioWeb = new ServicioWebClient();
            InitializeComponent();
            dgvBlancos.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBlancos.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBlancos.DataSource = _daoServicioWeb.listarBlancosPorNombre(txtNombre.Text);
        }

        private void dgvBlancos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            blanco blancoAux = (blanco)dgvBlancos.Rows[e.RowIndex].DataBoundItem;
            dgvBlancos.Rows[e.RowIndex].Cells[0].Value = blancoAux.idBlanco;
            dgvBlancos.Rows[e.RowIndex].Cells[1].Value = blancoAux.blancoMovimiento;
            dgvBlancos.Rows[e.RowIndex].Cells[2].Value = blancoAux.descripcion;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvBlancos.CurrentRow.Index != -1)
            {
                Blanco = (blanco)dgvBlancos.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
