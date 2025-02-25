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
            Datos obj = new Datos();
            DataSet ds = obj.Consulta("Select au_id as ID,au_lname as [Last Name],au_fname as [Firts Name],phone as Phone,authors.address as Address,city as City,state as State,zip as Zip,contract as Contract From authors");
            if (ds != null)
            {
                dgvAuthors.DataSource = ds.Tables[0];
            }
        }
    }
}
