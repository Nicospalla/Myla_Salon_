namespace SoftwareGestion_Myla
{
    partial class frmUsuarios
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
            btnAtras = new Button();
            dgvUser = new DataGridView();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            rbNO = new RadioButton();
            rbSI = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblErrorPass = new Label();
            lblErrorUser = new Label();
            lblNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnEditarActivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(90, 90);
            btnAtras.TabIndex = 14;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.AllowUserToResizeColumns = false;
            dgvUser.AllowUserToResizeRows = false;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Location = new Point(537, 235);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 29;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(525, 234);
            dgvUser.TabIndex = 15;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(38, 55);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(166, 27);
            txtUsuario.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 27);
            txtPassword.TabIndex = 17;
            // 
            // rbNO
            // 
            rbNO.AutoSize = true;
            rbNO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbNO.Location = new Point(38, 220);
            rbNO.Name = "rbNO";
            rbNO.Size = new Size(53, 24);
            rbNO.TabIndex = 18;
            rbNO.TabStop = true;
            rbNO.Text = "NO";
            rbNO.UseVisualStyleBackColor = true;
            // 
            // rbSI
            // 
            rbSI.AutoSize = true;
            rbSI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbSI.Location = new Point(131, 220);
            rbSI.Name = "rbSI";
            rbSI.Size = new Size(43, 24);
            rbSI.TabIndex = 19;
            rbSI.TabStop = true;
            rbSI.Text = "SI";
            rbSI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 20;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 108);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 21;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 190);
            label3.Name = "label3";
            label3.Size = new Size(135, 18);
            label3.TabIndex = 22;
            label3.Text = "ADMINISTRADOR";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblErrorPass);
            panel1.Controls.Add(lblErrorUser);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(rbSI);
            panel1.Controls.Add(rbNO);
            panel1.Location = new Point(222, 235);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 285);
            panel1.TabIndex = 23;
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(41, 159);
            lblErrorPass.Name = "lblErrorPass";
            lblErrorPass.Size = new Size(45, 16);
            lblErrorPass.TabIndex = 24;
            lblErrorPass.Text = "label4";
            // 
            // lblErrorUser
            // 
            lblErrorUser.AutoSize = true;
            lblErrorUser.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorUser.ForeColor = Color.Red;
            lblErrorUser.Location = new Point(41, 85);
            lblErrorUser.Name = "lblErrorUser";
            lblErrorUser.Size = new Size(45, 16);
            lblErrorUser.TabIndex = 23;
            lblErrorUser.Text = "label4";
            // 
            // lblNuevo
            // 
            lblNuevo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevo.Location = new Point(537, 475);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(171, 45);
            lblNuevo.TabIndex = 24;
            lblNuevo.Text = "Crear Usuario";
            lblNuevo.UseVisualStyleBackColor = true;
            lblNuevo.Click += lblNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditar.Location = new Point(714, 475);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(171, 45);
            btnEditar.TabIndex = 25;
            btnEditar.Text = "Editar Usuario";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(891, 475);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(171, 45);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(256, 526);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(171, 45);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditarActivo
            // 
            btnEditarActivo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarActivo.Location = new Point(714, 526);
            btnEditarActivo.Name = "btnEditarActivo";
            btnEditarActivo.Size = new Size(171, 45);
            btnEditarActivo.TabIndex = 28;
            btnEditarActivo.Text = "Editar Usuario Activo";
            btnEditarActivo.UseVisualStyleBackColor = true;
            btnEditarActivo.Click += btnEditarActivo_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 731);
            Controls.Add(btnEditarActivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(lblNuevo);
            Controls.Add(dgvUser);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAtras;
        private DataGridView dgvUser;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private RadioButton rbNO;
        private RadioButton rbSI;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button lblNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label label4;
        private Label lblErrorUser;
        private Label lblErrorPass;
        private Button btnEditarActivo;
    }
}