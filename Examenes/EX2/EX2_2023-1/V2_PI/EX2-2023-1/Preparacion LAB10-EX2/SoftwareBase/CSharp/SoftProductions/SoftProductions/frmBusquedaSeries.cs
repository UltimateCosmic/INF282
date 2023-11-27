using SoftProductions.SoftProductionsWS;
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

namespace SoftProductions
{
    public partial class frmBusquedaSeries : Form
    {
        private SoftProductionsWSClient _daoSoftProductionsWS;
        private serieTelevision _serie;
        public frmBusquedaSeries()
        {
            _daoSoftProductionsWS
                 = new SoftProductionsWSClient();
            InitializeComponent();
            dgvSeries.AutoGenerateColumns = false;
        }

        public serieTelevision Serie { get => _serie; set => _serie = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSeries.DataSource = _daoSoftProductionsWS.listarSeriesXNombre(txtNombre.Text);
        }

        private void dgvSeries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            serieTelevision serieAux = (serieTelevision)dgvSeries.Rows[e.RowIndex].DataBoundItem;
            dgvSeries.Rows[e.RowIndex].Cells[0].Value = serieAux.nombreSerie;
            dgvSeries.Rows[e.RowIndex].Cells[1].Value = serieAux.productora.nombreProductora;
            if (serieAux.idioma == 'E')
                dgvSeries.Rows[e.RowIndex].Cells[2].Value = "Español";
            else if (serieAux.idioma == 'I')
                dgvSeries.Rows[e.RowIndex].Cells[2].Value = "Inglés";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSeries.CurrentRow.Index != -1)
            {
                _serie = (serieTelevision)dgvSeries.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
