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
            lblCat = new Label();
            lblSubCat = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
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
            btnAgregar.Location = new Point(170, 491);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 63);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(463, 491);
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
            pnlEsp.Controls.Add(lblCat);
            pnlEsp.Controls.Add(lblSubCat);
            pnlEsp.Controls.Add(comboBox2);
            pnlEsp.Controls.Add(comboBox1);
            pnlEsp.Location = new Point(463, 329);
            pnlEsp.Name = "pnlEsp";
            pnlEsp.Size = new Size(278, 144);
            pnlEsp.TabIndex = 14;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCat.Location = new Point(12, 14);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(87, 18);
            lblCat.TabIndex = 21;
            lblCat.Text = "Categoria:";
            // 
            // lblSubCat
            // 
            lblSubCat.AutoSize = true;
            lblSubCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubCat.Location = new Point(12, 82);
            lblSubCat.Name = "lblSubCat";
            lblSubCat.Size = new Size(115, 18);
            lblSubCat.TabIndex = 20;
            lblSubCat.Text = "SubCategoria:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(11, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(250, 28);
            comboBox2.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 28);
            comboBox1.TabIndex = 17;
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(950, 600);
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}