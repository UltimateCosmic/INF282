using GameSoft.ServicioWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameSoft
{
    public partial class frmBusquedaPokemons : Form
    {
        private ServicioWebClient _daoServicioWeb;
        private pokemon _pokemon;

        public pokemon Pokemon { get => _pokemon; set => _pokemon = value; }

        public frmBusquedaPokemons()
        {
            _daoServicioWeb = new ServicioWebClient();
            InitializeComponent();
            dgvPokemons.AutoGenerateColumns = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPokemons.DataSource = _daoServicioWeb.listarPokemonesPorNombre(txtNombre.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPokemons.CurrentRow.Index != -1)
            {
                _pokemon = (pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void dgvPokemons_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
