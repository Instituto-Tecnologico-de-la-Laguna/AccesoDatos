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
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor(string id,string fname,string lname,
            string phone,string address,string city,string state,string zip,
            bool contract)
        {
            InitializeComponent();
        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {

        }
    }
}
