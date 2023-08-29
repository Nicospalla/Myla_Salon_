namespace SoftwareGestion_Myla
{
    partial class frmNuevoCliente
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
            lblTitulo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTel = new Label();
            txtTel = new TextBox();
            lblCumple = new Label();
            datePickerCumple = new DateTimePicker();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            btnAtras = new Button();
            pnlEsp = new Panel();
            txtPorcentaje = new TextBox();
            txtSueldo = new TextBox();
            lblFinanzas = new Label();
            lblSueldo = new Label();
            lblPorcentaje = new Label();
            label9 = new Label();
            label8 = new Label();
            pnlEsp.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(130, 86);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(184, 28);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Cliente:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 197);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(137, 162);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.Location = new Point(137, 252);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 18);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 287);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(248, 27);
            txtApellido.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(137, 352);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 18);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 387);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTel.Location = new Point(475, 162);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(77, 18);
            lblTel.TabIndex = 8;
            lblTel.Text = "Teléfono:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(475, 197);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(250, 27);
            txtTel.TabIndex = 7;
            // 
            // lblCumple
            // 
            lblCumple.AutoSize = true;
            lblCumple.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumple.Location = new Point(475, 252);
            lblCumple.Name = "lblCumple";
            lblCumple.Size = new Size(170, 18);
            lblCumple.TabIndex = 9;
            lblCumple.Text = "Fecha de Nacimiento:";
            // 
            // datePickerCumple
            // 
            datePickerCumple.Location = new Point(475, 285);
            datePickerCumple.Name = "datePickerCumple";
            datePickerCumple.Size = new Size(250, 27);
            datePickerCumple.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(182, 457);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 63);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(475, 457);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 63);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(90, 90);
            btnAtras.TabIndex = 13;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // pnlEsp
            // 
            pnlEsp.Controls.Add(label8);
            pnlEsp.Controls.Add(label9);
            pnlEsp.Controls.Add(lblPorcentaje);
            pnlEsp.Controls.Add(lblSueldo);
            pnlEsp.Controls.Add(lblFinanzas);
            pnlEsp.Controls.Add(txtSueldo);
            pnlEsp.Controls.Add(txtPorcentaje);
            pnlEsp.Location = new Point(797, 86);
            pnlEsp.Name = "pnlEsp";
            pnlEsp.Size = new Size(317, 456);
            pnlEsp.TabIndex = 37;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(18, 284);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(230, 27);
            txtPorcentaje.TabIndex = 37;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(18, 199);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(230, 27);
            txtSueldo.TabIndex = 38;
            // 
            // lblFinanzas
            // 
            lblFinanzas.AutoSize = true;
            lblFinanzas.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblFinanzas.Location = new Point(18, 111);
            lblFinanzas.Name = "lblFinanzas";
            lblFinanzas.Size = new Size(123, 28);
            lblFinanzas.TabIndex = 39;
            lblFinanzas.Text = "Finanzas:";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldo.Location = new Point(18, 161);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(103, 18);
            lblSueldo.TabIndex = 40;
            lblSueldo.Text = "Sueldo FIJO:";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPorcentaje.Location = new Point(18, 246);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(95, 18);
            lblPorcentaje.TabIndex = 41;
            lblPorcentaje.Text = "Porcentaje:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Window;
            label9.Location = new Point(214, 204);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 42;
            label9.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Window;
            label8.Location = new Point(214, 287);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 43;
            label8.Text = "%";
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1200, 600);
            Controls.Add(pnlEsp);
            Controls.Add(btnAtras);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(datePickerCumple);
            Controls.Add(lblCumple);
            Controls.Add(lblTel);
            Controls.Add(txtTel);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNuevoCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmVenta";
            Load += frmNuevoCliente_Load;
            pnlEsp.ResumeLayout(false);
            pnlEsp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTel;
        private TextBox txtTel;
        private Label lblCumple;
        private DateTimePicker datePickerCumple;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Button btnAtras;
        private Panel pnlEsp;
        private Label lblCat;
        private Label lblSubCat;
        private ComboBox cboSubCat;
        private ComboBox cboCat;
        private Label lblPorcentaje;
        private Label lblSueldo;
        private Label lblFinanzas;
        private TextBox txtSueldo;
        private TextBox txtPorcentaje;
        private Label label9;
        private Label label8;
    }
}