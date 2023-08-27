namespace SoftwareGestion_Myla
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelIzq = new Panel();
            btnNuevoEsp = new Button();
            btnNuevo = new Button();
            btnCerrar = new Button();
            btnGrillaClientes = new Button();
            panelSup = new Panel();
            panelLogin = new Panel();
            btnCerrarSession = new Button();
            lblUser = new Label();
            lblUserActivo = new Label();
            panelReloj = new Panel();
            lblFecha = new Label();
            lblReloj = new Label();
            panelPpal = new Panel();
            btnEditarEsp = new Button();
            panelIzq.SuspendLayout();
            panelSup.SuspendLayout();
            panelLogin.SuspendLayout();
            panelReloj.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzq
            // 
            panelIzq.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelIzq.BackColor = SystemColors.ActiveCaption;
            panelIzq.Controls.Add(btnEditarEsp);
            panelIzq.Controls.Add(btnNuevoEsp);
            panelIzq.Controls.Add(btnNuevo);
            panelIzq.Controls.Add(btnCerrar);
            panelIzq.Location = new Point(1, 109);
            panelIzq.Name = "panelIzq";
            panelIzq.Size = new Size(229, 543);
            panelIzq.TabIndex = 0;
            // 
            // btnNuevoEsp
            // 
            btnNuevoEsp.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnNuevoEsp.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnNuevoEsp.FlatStyle = FlatStyle.Flat;
            btnNuevoEsp.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoEsp.Location = new Point(11, 99);
            btnNuevoEsp.Name = "btnNuevoEsp";
            btnNuevoEsp.Size = new Size(202, 60);
            btnNuevoEsp.TabIndex = 3;
            btnNuevoEsp.Text = "Nuevo Especialista";
            btnNuevoEsp.UseVisualStyleBackColor = true;
            btnNuevoEsp.Click += btnNuevoEsp_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnNuevo.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Location = new Point(11, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(202, 60);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo Cliente";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCerrar.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnCerrar.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.Location = new Point(11, 469);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(202, 63);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGrillaClientes
            // 
            btnGrillaClientes.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnGrillaClientes.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnGrillaClientes.FlatStyle = FlatStyle.Flat;
            btnGrillaClientes.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGrillaClientes.Location = new Point(235, 28);
            btnGrillaClientes.Name = "btnGrillaClientes";
            btnGrillaClientes.Size = new Size(200, 60);
            btnGrillaClientes.TabIndex = 1;
            btnGrillaClientes.Text = "Pantalla Principal";
            btnGrillaClientes.UseVisualStyleBackColor = true;
            btnGrillaClientes.Click += btnGrillaClientes_Click;
            // 
            // panelSup
            // 
            panelSup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelSup.BackColor = SystemColors.ActiveCaption;
            panelSup.Controls.Add(panelLogin);
            panelSup.Controls.Add(panelReloj);
            panelSup.Controls.Add(btnGrillaClientes);
            panelSup.Location = new Point(1, 0);
            panelSup.Name = "panelSup";
            panelSup.Size = new Size(1081, 114);
            panelSup.TabIndex = 0;
            // 
            // panelLogin
            // 
            panelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelLogin.BorderStyle = BorderStyle.Fixed3D;
            panelLogin.Controls.Add(btnCerrarSession);
            panelLogin.Controls.Add(lblUser);
            panelLogin.Controls.Add(lblUserActivo);
            panelLogin.Location = new Point(467, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(437, 88);
            panelLogin.TabIndex = 7;
            // 
            // btnCerrarSession
            // 
            btnCerrarSession.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSession.Location = new Point(343, 9);
            btnCerrarSession.Name = "btnCerrarSession";
            btnCerrarSession.Size = new Size(70, 70);
            btnCerrarSession.TabIndex = 2;
            btnCerrarSession.Text = "Cerrar Sesión";
            btnCerrarSession.UseVisualStyleBackColor = true;
            btnCerrarSession.Click += btnCerrarSession_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(108, 44);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(17, 22);
            lblUser.TabIndex = 1;
            lblUser.Text = ".";
            // 
            // lblUserActivo
            // 
            lblUserActivo.AutoSize = true;
            lblUserActivo.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserActivo.Location = new Point(23, 18);
            lblUserActivo.Name = "lblUserActivo";
            lblUserActivo.Size = new Size(147, 22);
            lblUserActivo.TabIndex = 0;
            lblUserActivo.Text = "Usuario Activo:";
            // 
            // panelReloj
            // 
            panelReloj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelReloj.BorderStyle = BorderStyle.Fixed3D;
            panelReloj.Controls.Add(lblFecha);
            panelReloj.Controls.Add(lblReloj);
            panelReloj.Location = new Point(910, 12);
            panelReloj.Name = "panelReloj";
            panelReloj.Size = new Size(159, 88);
            panelReloj.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(49, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(92, 35);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // lblReloj
            // 
            lblReloj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReloj.AutoSize = true;
            lblReloj.Font = new Font("Microsoft JhengHei", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblReloj.Location = new Point(60, 9);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(81, 35);
            lblReloj.TabIndex = 1;
            lblReloj.Text = "Reloj";
            // 
            // panelPpal
            // 
            panelPpal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPpal.Location = new Point(236, 117);
            panelPpal.Name = "panelPpal";
            panelPpal.Size = new Size(843, 535);
            panelPpal.TabIndex = 8;
            // 
            // btnEditarEsp
            // 
            btnEditarEsp.FlatAppearance.BorderColor = SystemColors.GradientInactiveCaption;
            btnEditarEsp.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btnEditarEsp.FlatStyle = FlatStyle.Flat;
            btnEditarEsp.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarEsp.Location = new Point(11, 177);
            btnEditarEsp.Name = "btnEditarEsp";
            btnEditarEsp.Size = new Size(202, 60);
            btnEditarEsp.TabIndex = 4;
            btnEditarEsp.Text = "Editar Especialista";
            btnEditarEsp.UseVisualStyleBackColor = true;
            btnEditarEsp.Click += btnEditarEsp_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 653);
            Controls.Add(panelPpal);
            Controls.Add(panelSup);
            Controls.Add(panelIzq);
            MinimumSize = new Size(1100, 700);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Myla Salon Studio";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            panelIzq.ResumeLayout(false);
            panelSup.ResumeLayout(false);
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelReloj.ResumeLayout(false);
            panelReloj.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzq;
        private Panel panelSup;
        private Label lblReloj;
        private Label lblFecha;
        private Button btnCerrar;
        private Button btnGrillaClientes;
        private Panel panelLogin;
        private Panel panelPpal;
        private Panel panelReloj;
        private Button btnCerrarSession;
        private Label lblUser;
        private Label lblUserActivo;
        private Button btnNuevo;
        private Button btnNuevoEsp;
        private Button btnEditarEsp;
    }
}