namespace AccesoDatos
{
    partial class frmActualizaAutor
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
            label1 = new Label();
            txtId = new TextBox();
            txtFirst = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtLast = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtZip = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label8 = new Label();
            txtState = new TextBox();
            chkContract = new CheckBox();
            btnActualizar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 1;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(12, 113);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(253, 31);
            txtFirst.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(288, 113);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(253, 31);
            txtLast.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 161);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 9;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(188, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(353, 31);
            txtAddress.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 244);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 11;
            label6.Text = "ZIP Code";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(366, 272);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(150, 31);
            txtZip.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 244);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 13;
            label7.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 272);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 244);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 15;
            label8.Text = "State";
            // 
            // txtState
            // 
            txtState.Location = new Point(188, 272);
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 14;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(12, 331);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(105, 29);
            chkContract.TabIndex = 16;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(311, 326);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 17;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(429, 327);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmActualizaAutor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 376);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(chkContract);
            Controls.Add(label8);
            Controls.Add(txtState);
            Controls.Add(label7);
            Controls.Add(txtCity);
            Controls.Add(label6);
            Controls.Add(txtZip);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtLast);
            Controls.Add(label2);
            Controls.Add(txtFirst);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "frmActualizaAutor";
            Text = "Actualiza Autor";
            Load += frmActualizaAutor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private TextBox txtFirst;
        private Label label2;
        private Label label3;
        private TextBox txtLast;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtZip;
        private Label label7;
        private TextBox txtCity;
        private Label label8;
        private TextBox txtState;
        private CheckBox chkContract;
        private Button btnActualizar;
        private Button btnCancelar;
    }
}