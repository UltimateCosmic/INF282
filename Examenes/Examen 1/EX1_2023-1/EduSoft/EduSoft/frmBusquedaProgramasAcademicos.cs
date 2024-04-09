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
    public partial class frmBusquedaProgramasAcademicos : Form
    {
        private ProgramaAcademicoDAO _daoProgramaAcademico;
        private ProgramaAcademico _programaAcademicoSeleccionado;
        public frmBusquedaProgramasAcademicos()
        {
            _daoProgramaAcademico = new ProgramaAcademicoMySQL();
            InitializeComponent();
            dgvProgramas.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProgramas.AutoGenerateColumns = false;
        }

        public ProgramaAcademico ProgramaAcademicoSeleccionado { get => _programaAcademicoSeleccionado; set => _programaAcademicoSeleccionado = value; }
        private void dgvProgramas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ProgramaAcademico programa = (ProgramaAcademico)dgvProgramas.Rows[e.RowIndex].DataBoundItem;
            if (programa.TipoProgramaAcademico == 'C')
            {
                dgvProgramas.Rows[e.RowIndex].Cells[0].Value = "CURSO";
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = ((Curso)programa).CantidadCreditos;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = ((Curso)programa).FechaInicio.ToString("dd-MM-yyyy");
            }                
            else if (programa.TipoProgramaAcademico == 'T')
            {
                dgvProgramas.Rows[e.RowIndex].Cells[0].Value = "TALLER";
                dgvProgramas.Rows[e.RowIndex].Cells[3].Value = ((Taller)programa).CantidadHoras;
                dgvProgramas.Rows[e.RowIndex].Cells[4].Value = ((Taller)programa).FechaRealizacion.ToString("dd-MM-yyyy");
            }
            dgvProgramas.Rows[e.RowIndex].Cells[1].Value = programa.Clave;
            dgvProgramas.Rows[e.RowIndex].Cells[2].Value = programa.Nombre;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProgramas.DataSource = _daoProgramaAcademico.listarPorNombreClave(txtNombreClave.Text);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ProgramaAcademicoSeleccionado = (ProgramaAcademico)dgvProgramas.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
