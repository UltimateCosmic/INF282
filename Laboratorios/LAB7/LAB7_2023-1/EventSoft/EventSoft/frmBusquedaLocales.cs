using EventSoftController.DAO;
using EventSoftController.MySQL;
using EventSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSoft
{
    public partial class frmBusquedaLocales : Form
    {
        private Local localSel;
        private LocalDAO _daoLocal;

        public frmBusquedaLocales()
        {
            _daoLocal = new LocalMySQL();
            InitializeComponent();
            dgvLocales.AutoGenerateColumns = false;
        }

        private void dgvLocales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Local local = (Local) dgvLocales.Rows[e.RowIndex].DataBoundItem;
            dgvLocales.Rows[e.RowIndex].Cells[0].Value = local.IdLocal;
            dgvLocales.Rows[e.RowIndex].Cells[1].Value = local.Nombre;
            dgvLocales.Rows[e.RowIndex].Cells[2].Value = local.EstiloArquitectonico.Nombre;
            localSel = local;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvLocales.DataSource = _daoLocal.lista(txtNombre.Text);
        }

        private void dgvLocales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmGestionLocales formGesLoc = new frmGestionLocales();
            formGesLoc.listarLocal(localSel);
            if (formGesLoc.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void btnSeleccionar_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
