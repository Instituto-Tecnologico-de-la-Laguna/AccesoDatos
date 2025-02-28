namespace AccesoDatos
{
    partial class frmInsertar
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
            btnCancelar = new Button();
            btnInsertar = new Button();
            chkContract = new CheckBox();
            label8 = new Label();
            txtState = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            label6 = new Label();
            txtZip = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(429, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 38;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(302, 326);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(112, 34);
            btnInsertar.TabIndex = 37;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // chkContract
            // 
            chkContract.AutoSize = true;
            chkContract.Location = new Point(12, 331);
            chkContract.Name = "chkContract";
            chkContract.Size = new Size(105, 29);
            chkContract.TabIndex = 36;
            chkContract.Text = "Contract";
            chkContract.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(188, 244);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 35;
            label8.Text = "State";
            // 
            // txtState
            // 
            txtState.Location = new Point(188, 272);
            txtState.Name = "txtState";
            txtState.Size = new Size(150, 31);
            txtState.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 244);
            label7.Name = "label7";
            label7.Size = new Size(42, 25);
            label7.TabIndex = 33;
            label7.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 272);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(366, 244);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 31;
            label6.Text = "ZIP Code";
            // 
            // txtZip
            // 
            txtZip.Location = new Point(366, 272);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(150, 31);
            txtZip.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 161);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 29;
            label5.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(188, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(353, 31);
            txtAddress.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 27;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 25;
            label3.Text = "Last Name";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(288, 113);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(253, 31);
            txtLast.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 23;
            label2.Text = "First Name";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(12, 113);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(253, 31);
            txtFirst.TabIndex = 22;
            // 
            // txtId
            // 
            txtId.Location = new Point(12, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(150, 31);
            txtId.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 20;
            label1.Text = "Id";
            // 
            // frmInsertar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 379);
            Controls.Add(btnCancelar);
            Controls.Add(btnInsertar);
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
            Name = "frmInsertar";
            Text = "Añadir Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnInsertar;
        private CheckBox chkContract;
        private Label label8;
        private TextBox txtState;
        private Label label7;
        private TextBox txtCity;
        private Label label6;
        private TextBox txtZip;
        private Label label5;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLast;
        private Label label2;
        private TextBox txtFirst;
        private TextBox txtId;
        private Label label1;
    }
}