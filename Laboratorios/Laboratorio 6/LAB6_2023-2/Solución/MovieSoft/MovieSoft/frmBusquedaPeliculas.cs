using MovieSoftController.DAO;
using MovieSoftController.MySQL;
using MovieSoftModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSoft
{
    public partial class frmBusquedaPeliculas : Form
    {
        private Pelicula _pelicula;
        private PeliculaDAO _daoPelicula;
        private Pelicula peliculaSel;

        public frmBusquedaPeliculas()
        {
            _daoPelicula = new PeliculaMySQL();
            InitializeComponent();
            dgvPeliculas.AutoGenerateColumns = false;
        }
        public Pelicula Pelicula { get => _pelicula; set => _pelicula = value; }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.CurrentRow.Index != -1) {
                Pelicula = (Pelicula) dgvPeliculas.CurrentRow.DataBoundItem;
                frmGestionPeliculas formGesPel = new frmGestionPeliculas();
                formGesPel.listarPelicula(peliculaSel);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = _daoPelicula.lista();
        }

        private void dgvPeliculas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Pelicula pelicula = (Pelicula)dgvPeliculas.Rows[e.RowIndex].DataBoundItem;
            dgvPeliculas.Rows[e.RowIndex].Cells[0].Value = pelicula.Nombre;
            dgvPeliculas.Rows[e.RowIndex].Cells[1].Value = pelicula.Genero.Nombre;
            peliculaSel = pelicula;
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
