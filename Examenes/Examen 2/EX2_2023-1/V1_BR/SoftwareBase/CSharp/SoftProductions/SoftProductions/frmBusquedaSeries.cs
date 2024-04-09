using SoftProductions.ProductoraWS;
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
    public partial class frmBusquedaSeries : Form
    {
        private ProductoraWSClient _daoProductora;
        private serieTelevision _serieSeleccionada;
        public frmBusquedaSeries()
        {
            InitializeComponent();
            _daoProductora = new ProductoraWSClient();
            dgvSeries.AutoGenerateColumns = false;
        }

        public serieTelevision SerieSeleccionada { get => _serieSeleccionada; set => _serieSeleccionada = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSeries.DataSource = _daoProductora.listarPorNombre(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvSeries.CurrentRow.Index != -1)
            {
                _serieSeleccionada = (serieTelevision)dgvSeries.CurrentRow.DataBoundItem;
                _serieSeleccionada.capitulos = _daoProductora.listarPorIdSerie(SerieSeleccionada.idSerieTelevision);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void dgvSeries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            serieTelevision ser = (serieTelevision)dgvSeries.Rows[e.RowIndex].DataBoundItem;
            dgvSeries.Rows[e.RowIndex].Cells[0].Value = ser.nombreSerie;
            dgvSeries.Rows[e.RowIndex].Cells[1].Value = ser.productora.nombreProductora;
            dgvSeries.Rows[e.RowIndex].Cells[2].Value = ser.idioma == 'E' ? "ESPAÑOL" : "INGLES";
        }
    }
}
