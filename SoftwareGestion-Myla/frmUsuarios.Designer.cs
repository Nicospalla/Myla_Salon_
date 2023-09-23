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
            panel2 = new Panel();
            btnRestaurar = new Button();
            btnOpenFile = new Button();
            label4 = new Label();
            txtFile = new TextBox();
            pnlBackUp = new Panel();
            lblEnviando = new Label();
            btnGenerar = new Button();
            lblGenerar = new Label();
            panel3 = new Panel();
            lbTitleBack = new Label();
            panel4 = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlBackUp.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            dgvUser.Location = new Point(168, 356);
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
            txtUsuario.Location = new Point(48, 40);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(166, 27);
            txtUsuario.TabIndex = 16;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(277, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 27);
            txtPassword.TabIndex = 17;
            // 
            // rbNO
            // 
            rbNO.AutoSize = true;
            rbNO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbNO.Location = new Point(161, 143);
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
            rbSI.Location = new Point(282, 143);
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
            label1.Location = new Point(48, 21);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 20;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(277, 19);
            label2.Name = "label2";
            label2.Size = new Size(101, 18);
            label2.TabIndex = 21;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 113);
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
            panel1.Location = new Point(168, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 185);
            panel1.TabIndex = 23;
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(280, 70);
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
            lblErrorUser.Location = new Point(51, 70);
            lblErrorUser.Name = "lblErrorUser";
            lblErrorUser.Size = new Size(45, 16);
            lblErrorUser.TabIndex = 23;
            lblErrorUser.Text = "label4";
            // 
            // lblNuevo
            // 
            lblNuevo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNuevo.Location = new Point(168, 596);
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
            btnEditar.Location = new Point(345, 596);
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
            btnEliminar.Location = new Point(522, 596);
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
            btnGuardar.Location = new Point(345, 305);
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
            btnEditarActivo.Location = new Point(345, 647);
            btnEditarActivo.Name = "btnEditarActivo";
            btnEditarActivo.Size = new Size(171, 45);
            btnEditarActivo.TabIndex = 28;
            btnEditarActivo.Text = "Editar Usuario Activo";
            btnEditarActivo.UseVisualStyleBackColor = true;
            btnEditarActivo.Click += btnEditarActivo_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnRestaurar);
            panel2.Controls.Add(btnOpenFile);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtFile);
            panel2.Location = new Point(35, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 147);
            panel2.TabIndex = 30;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestaurar.Location = new Point(69, 94);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(278, 29);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar Base de Datos";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click_1;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(323, 44);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(65, 27);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Buscar";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 18);
            label4.Name = "label4";
            label4.Size = new Size(198, 18);
            label4.TabIndex = 6;
            label4.Text = "Restaurar Base de datos:";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(13, 44);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(375, 27);
            txtFile.TabIndex = 2;
            // 
            // pnlBackUp
            // 
            pnlBackUp.BorderStyle = BorderStyle.FixedSingle;
            pnlBackUp.Controls.Add(lblEnviando);
            pnlBackUp.Controls.Add(btnGenerar);
            pnlBackUp.Controls.Add(lblGenerar);
            pnlBackUp.Location = new Point(35, 52);
            pnlBackUp.Name = "pnlBackUp";
            pnlBackUp.Size = new Size(403, 84);
            pnlBackUp.TabIndex = 29;
            // 
            // lblEnviando
            // 
            lblEnviando.AutoSize = true;
            lblEnviando.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnviando.ForeColor = Color.Red;
            lblEnviando.Location = new Point(27, 125);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Size = new Size(0, 16);
            lblEnviando.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerar.Location = new Point(69, 36);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(278, 29);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Registar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // lblGenerar
            // 
            lblGenerar.AutoSize = true;
            lblGenerar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenerar.Location = new Point(140, 15);
            lblGenerar.Name = "lblGenerar";
            lblGenerar.Size = new Size(140, 18);
            lblGenerar.TabIndex = 1;
            lblGenerar.Text = "Generar BackUp";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pnlBackUp);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(lbTitleBack);
            panel3.Location = new Point(752, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 338);
            panel3.TabIndex = 31;
            // 
            // lbTitleBack
            // 
            lbTitleBack.AutoSize = true;
            lbTitleBack.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitleBack.Location = new Point(163, 13);
            lbTitleBack.Name = "lbTitleBack";
            lbTitleBack.Size = new Size(135, 18);
            lbTitleBack.TabIndex = 33;
            lbTitleBack.Text = "Sección BackUp";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(148, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(566, 652);
            panel4.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(187, 13);
            label5.Name = "label5";
            label5.Size = new Size(145, 18);
            label5.TabIndex = 33;
            label5.Text = "Sección Usuarios";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 799);
            Controls.Add(btnEditarActivo);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(lblNuevo);
            Controls.Add(dgvUser);
            Controls.Add(btnAtras);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBackUp.ResumeLayout(false);
            pnlBackUp.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel2;
        private Button btnRestaurar;
        private Button btnOpenFile;
        private TextBox txtFile;
        private Panel pnlBackUp;
        private Label lblEnviando;
        private Button btnGenerar;
        private Label lblGenerar;
        private Panel panel3;
        private Panel panel4;
        private Label lbTitleBack;
        private Label label5;
    }
}