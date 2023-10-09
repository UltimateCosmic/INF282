using EduSoftController.DAO;
using EduSoftController.MySQL;
using EduSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduSoft
{
    public partial class frmBusquedaEjecutivos : Form
    {
        private EjecutivoDAO _daoEjecutivo;
        private Ejecutivo _ejecutivoSeleccionado;
        public frmBusquedaEjecutivos()
        {
            _daoEjecutivo = new EjecutivoMySQL();
            InitializeComponent();
            dgvEjecutivos.AutoGenerateColumns = false;
        }

        public Ejecutivo EjecutivoSeleccionado { get => _ejecutivoSeleccionado; set => _ejecutivoSeleccionado = value; }

        private void dgvEjecutivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Ejecutivo ejecutivo = (Ejecutivo)dgvEjecutivos.Rows[e.RowIndex].DataBoundItem;
            dgvEjecutivos.Rows[e.RowIndex].Cells[0].Value = ejecutivo.DNI;
            dgvEjecutivos.Rows[e.RowIndex].Cells[1].Value = ejecutivo.Nombre + " " + ejecutivo.ApellidoPaterno;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEjecutivos.DataSource = _daoEjecutivo.listarPorNombreDNI(txtNombreDNI.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            EjecutivoSeleccionado = (Ejecutivo)dgvEjecutivos.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
