namespace SoftwareGestion_Myla
{
    partial class frmLogin
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
            btnIngresar = new Button();
            btnCancelar = new Button();
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(39, 247);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(189, 49);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(273, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(189, 49);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(79, 87);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(334, 27);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(79, 165);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(334, 27);
            txtPass.TabIndex = 3;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(79, 44);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(62, 20);
            lblUser.TabIndex = 4;
            lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(79, 132);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(86, 20);
            lblPass.TabIndex = 5;
            lblPass.Text = "Contraseña:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 344);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MYLA Salon Studio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnCancelar;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
    }
}