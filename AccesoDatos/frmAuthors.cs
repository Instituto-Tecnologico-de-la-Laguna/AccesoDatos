using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos
{
    public partial class frmAuthors : Form
    {
        public frmAuthors()
        {
            InitializeComponent();
        }

        private void frmAuthors_Load(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaAutor actualiza = new frmActualizaAutor(
                dgvAuthors[0, e.RowIndex].Value.ToString(),
                dgvAuthors[1, e.RowIndex].Value.ToString(),
                dgvAuthors[2, e.RowIndex].Value.ToString(),
                dgvAuthors[3, e.RowIndex].Value.ToString(),
                dgvAuthors[4, e.RowIndex].Value.ToString(),
                dgvAuthors[5, e.RowIndex].Value.ToString(),
                dgvAuthors[6, e.RowIndex].Value.ToString(),
                dgvAuthors[7, e.RowIndex].Value.ToString(),
                Convert.ToBoolean(dgvAuthors[8, e.RowIndex].Value));
            actualiza.Show();

        }

        private void frmAuthors_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select au_id as ID,au_lname as " +
                "[Last Name],au_fname as [Firts Name],phone as Phone," +
                "authors.address as Address,city as City,state as State," +
                "zip as Zip,contract as Contract From authors");
            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar inserta= new frmInsertar();
            inserta.Show();
        }
    }
}
