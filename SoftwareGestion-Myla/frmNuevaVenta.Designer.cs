namespace SoftwareGestion_Myla
{
    partial class frmNuevaVenta
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
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblEspecialista = new Label();
            cboEspecialista = new ComboBox();
            cboCategoria = new ComboBox();
            lblCategoria = new Label();
            cboSubCat = new ComboBox();
            lblSubCat = new Label();
            txtServAdc = new TextBox();
            lblSerAdc = new Label();
            textBox3 = new TextBox();
            lblCodigoTinte = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(99, 84);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 18);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(99, 121);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(224, 27);
            txtCliente.TabIndex = 2;
            // 
            // lblEspecialista
            // 
            lblEspecialista.AutoSize = true;
            lblEspecialista.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialista.Location = new Point(101, 313);
            lblEspecialista.Name = "lblEspecialista";
            lblEspecialista.Size = new Size(99, 18);
            lblEspecialista.TabIndex = 3;
            lblEspecialista.Text = "Especialista:";
            // 
            // cboEspecialista
            // 
            cboEspecialista.FormattingEnabled = true;
            cboEspecialista.Location = new Point(100, 359);
            cboEspecialista.Name = "cboEspecialista";
            cboEspecialista.Size = new Size(225, 28);
            cboEspecialista.TabIndex = 4;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(99, 244);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(225, 28);
            cboCategoria.TabIndex = 6;
            cboCategoria.SelectedValueChanged += cboCategoria_SelectedValueChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(100, 198);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(87, 18);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // cboSubCat
            // 
            cboSubCat.FormattingEnabled = true;
            cboSubCat.Location = new Point(463, 120);
            cboSubCat.Name = "cboSubCat";
            cboSubCat.Size = new Size(225, 28);
            cboSubCat.TabIndex = 8;
            cboSubCat.SelectedIndexChanged += cboSubCat_SelectedIndexChanged;
            // 
            // lblSubCat
            // 
            lblSubCat.AutoSize = true;
            lblSubCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubCat.Location = new Point(464, 84);
            lblSubCat.Name = "lblSubCat";
            lblSubCat.Size = new Size(120, 18);
            lblSubCat.TabIndex = 7;
            lblSubCat.Text = "Sub Categoria:";
            // 
            // txtServAdc
            // 
            txtServAdc.Location = new Point(463, 245);
            txtServAdc.Name = "txtServAdc";
            txtServAdc.Size = new Size(224, 27);
            txtServAdc.TabIndex = 10;
            // 
            // lblSerAdc
            // 
            lblSerAdc.AutoSize = true;
            lblSerAdc.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerAdc.Location = new Point(464, 198);
            lblSerAdc.Name = "lblSerAdc";
            lblSerAdc.Size = new Size(142, 18);
            lblSerAdc.TabIndex = 9;
            lblSerAdc.Text = "Servicio Adicional:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 27);
            textBox3.TabIndex = 12;
            // 
            // lblCodigoTinte
            // 
            lblCodigoTinte.AutoSize = true;
            lblCodigoTinte.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoTinte.Location = new Point(463, 313);
            lblCodigoTinte.Name = "lblCodigoTinte";
            lblCodigoTinte.Size = new Size(131, 18);
            lblCodigoTinte.TabIndex = 11;
            lblCodigoTinte.Text = "Codigo de Tinte:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 467);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(224, 27);
            txtPrecio.TabIndex = 14;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(100, 430);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 18);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(217, 526);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(168, 64);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(450, 526);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(168, 64);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(929, 622);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(textBox3);
            Controls.Add(lblCodigoTinte);
            Controls.Add(txtServAdc);
            Controls.Add(lblSerAdc);
            Controls.Add(cboSubCat);
            Controls.Add(lblSubCat);
            Controls.Add(cboCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(cboEspecialista);
            Controls.Add(lblEspecialista);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNuevaVenta";
            Text = "frmNuevaVenta";
            Load += frmNuevaVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblEspecialista;
        private ComboBox cboEspecialista;
        private ComboBox cboCategoria;
        private Label lblCategoria;
        private ComboBox cboSubCat;
        private Label lblSubCat;
        private TextBox txtServAdc;
        private Label lblSerAdc;
        private TextBox textBox3;
        private Label lblCodigoTinte;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button btnAceptar;
        private Button btnLimpiar;
    }
}