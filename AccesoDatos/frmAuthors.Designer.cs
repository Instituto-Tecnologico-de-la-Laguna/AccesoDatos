﻿namespace AccesoDatos
{
    partial class frmAuthors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAuthors = new DataGridView();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).BeginInit();
            SuspendLayout();
            // 
            // dgvAuthors
            // 
            dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuthors.Location = new Point(0, 64);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.RowHeadersWidth = 62;
            dgvAuthors.Size = new Size(1185, 386);
            dgvAuthors.TabIndex = 0;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(1063, 12);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // frmAuthors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 450);
            Controls.Add(btnInsertar);
            Controls.Add(dgvAuthors);
            Name = "frmAuthors";
            Text = "Authors";
            Activated += frmAuthors_Activated;
            Load += frmAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAuthors;
        private Button btnInsertar;
    }
}