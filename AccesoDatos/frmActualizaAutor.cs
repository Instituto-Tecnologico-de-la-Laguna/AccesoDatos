﻿using System;
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
        public frmActualizaAutor(string id, string fname, string lname,
            string phone, string address, string city, string state, string zip,
            bool contract)
        {
            InitializeComponent();
            txtFirst.Text = fname;
            txtLast.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtState.Text = state;
            txtZip.Text = zip;
            txtId.Text = id;
            chkContract.Checked = contract;


        }

        private void frmActualizaAutor_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update authors set " +
                "au_fname='" + txtFirst.Text +
                "', au_lname='" + txtLast.Text +
                "', phone='" + txtPhone.Text +
                "', address='" + txtAddress.Text +
                "', city='" + txtCity.Text +
                "', state='" + txtState.Text +
                "', zip='" + txtZip.Text +
                "', contract=" + (chkContract.Checked ? 1 : 0) +
                " where au_id='" + txtId.Text + "'");
            if (f == true)
            {
                MessageBox.Show("Datos Actualizados", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error al actualizar", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Está seguro de eliminar el registro?",
                "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Datos datos = new Datos();
                bool f = datos.comando("delete from authors where au_id='" + txtId.Text + "'");
                if (f == true)
                {
                    MessageBox.Show("Datos Eliminados", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

    }  
}