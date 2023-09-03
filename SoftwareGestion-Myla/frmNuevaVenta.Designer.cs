﻿namespace SoftwareGestion_Myla
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
            txtCodigoTinte = new TextBox();
            lblCodigoTinte = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            lblErrorCat = new Label();
            lblErrorEspe = new Label();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(137, 98);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 18);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(137, 146);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(285, 27);
            txtCliente.TabIndex = 2;
            // 
            // lblEspecialista
            // 
            lblEspecialista.AutoSize = true;
            lblEspecialista.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialista.Location = new Point(137, 203);
            lblEspecialista.Name = "lblEspecialista";
            lblEspecialista.Size = new Size(99, 18);
            lblEspecialista.TabIndex = 3;
            lblEspecialista.Text = "Especialista:";
            // 
            // cboEspecialista
            // 
            cboEspecialista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialista.FormattingEnabled = true;
            cboEspecialista.Location = new Point(137, 252);
            cboEspecialista.Name = "cboEspecialista";
            cboEspecialista.Size = new Size(286, 28);
            cboEspecialista.TabIndex = 4;
            cboEspecialista.SelectionChangeCommitted += cboEspecialista_SelectionChangeCommitted;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(137, 357);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(286, 28);
            cboCategoria.TabIndex = 6;
            cboCategoria.SelectedValueChanged += cboCategoria_SelectedValueChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(137, 309);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(87, 18);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // cboSubCat
            // 
            cboSubCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCat.FormattingEnabled = true;
            cboSubCat.Location = new Point(495, 145);
            cboSubCat.Name = "cboSubCat";
            cboSubCat.Size = new Size(285, 28);
            cboSubCat.TabIndex = 8;
            // 
            // lblSubCat
            // 
            lblSubCat.AutoSize = true;
            lblSubCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubCat.Location = new Point(497, 98);
            lblSubCat.Name = "lblSubCat";
            lblSubCat.Size = new Size(120, 18);
            lblSubCat.TabIndex = 7;
            lblSubCat.Text = "Sub Categoria:";
            // 
            // txtServAdc
            // 
            txtServAdc.Location = new Point(495, 252);
            txtServAdc.Name = "txtServAdc";
            txtServAdc.Size = new Size(285, 27);
            txtServAdc.TabIndex = 10;
            // 
            // lblSerAdc
            // 
            lblSerAdc.AutoSize = true;
            lblSerAdc.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerAdc.Location = new Point(497, 203);
            lblSerAdc.Name = "lblSerAdc";
            lblSerAdc.Size = new Size(142, 18);
            lblSerAdc.TabIndex = 9;
            lblSerAdc.Text = "Servicio Adicional:";
            // 
            // txtCodigoTinte
            // 
            txtCodigoTinte.Location = new Point(495, 358);
            txtCodigoTinte.Name = "txtCodigoTinte";
            txtCodigoTinte.Size = new Size(285, 27);
            txtCodigoTinte.TabIndex = 12;
            // 
            // lblCodigoTinte
            // 
            lblCodigoTinte.AutoSize = true;
            lblCodigoTinte.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoTinte.Location = new Point(495, 309);
            lblCodigoTinte.Name = "lblCodigoTinte";
            lblCodigoTinte.Size = new Size(131, 18);
            lblCodigoTinte.TabIndex = 11;
            lblCodigoTinte.Text = "Codigo de Tinte:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 463);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(285, 27);
            txtPrecio.TabIndex = 14;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(137, 415);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 18);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(254, 526);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(168, 64);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(487, 526);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(168, 64);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblErrorCat
            // 
            lblErrorCat.AutoSize = true;
            lblErrorCat.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCat.ForeColor = Color.Red;
            lblErrorCat.Location = new Point(137, 283);
            lblErrorCat.Name = "lblErrorCat";
            lblErrorCat.Size = new Size(0, 16);
            lblErrorCat.TabIndex = 17;
            // 
            // lblErrorEspe
            // 
            lblErrorEspe.AutoSize = true;
            lblErrorEspe.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEspe.ForeColor = Color.Red;
            lblErrorEspe.Location = new Point(137, 388);
            lblErrorEspe.Name = "lblErrorEspe";
            lblErrorEspe.Size = new Size(0, 16);
            lblErrorEspe.TabIndex = 18;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(90, 90);
            btnAtras.TabIndex = 19;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // frmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(929, 622);
            Controls.Add(btnAtras);
            Controls.Add(lblErrorEspe);
            Controls.Add(lblErrorCat);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtCodigoTinte);
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
        private TextBox txtCodigoTinte;
        private Label lblCodigoTinte;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private Button btnAceptar;
        private Button btnLimpiar;
        private Label lblErrorCat;
        private Label lblErrorEspe;
        private Button btnAtras;
    }
}