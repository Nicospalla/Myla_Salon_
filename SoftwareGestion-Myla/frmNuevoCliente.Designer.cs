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
            label1 = new Label();
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(130, 86);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Cliente:";
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
            lblTel.Location = new Point(478, 162);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(77, 18);
            lblTel.TabIndex = 8;
            lblTel.Text = "Teléfono:";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(478, 197);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(248, 27);
            txtTel.TabIndex = 7;
            // 
            // lblCumple
            // 
            lblCumple.AutoSize = true;
            lblCumple.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumple.Location = new Point(478, 252);
            lblCumple.Name = "lblCumple";
            lblCumple.Size = new Size(170, 18);
            lblCumple.TabIndex = 9;
            lblCumple.Text = "Fecha de Nacimiento:";
            // 
            // datePickerCumple
            // 
            datePickerCumple.Location = new Point(478, 285);
            datePickerCumple.Name = "datePickerCumple";
            datePickerCumple.Size = new Size(250, 27);
            datePickerCumple.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(170, 460);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(204, 63);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(463, 460);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 63);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(839, 571);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNuevoCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}