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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dgvVentas = new DataGridView();
            btnRegistrarVenta = new Button();
            btnBorraServ = new Button();
            txtPorcentaje = new TextBox();
            label1 = new Label();
            lblErrorSub = new Label();
            lblErrorPrecio = new Label();
            txtPrecioTotal = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            lblBuscaId = new Label();
            btnBuscar = new Button();
            lblErrorID = new Label();
            lblErrorPorcen = new Label();
            lblMetodo = new Label();
            cboMetodo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(104, 148);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 18);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(104, 178);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(228, 27);
            txtCliente.TabIndex = 1;
            // 
            // lblEspecialista
            // 
            lblEspecialista.AutoSize = true;
            lblEspecialista.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspecialista.Location = new Point(104, 254);
            lblEspecialista.Name = "lblEspecialista";
            lblEspecialista.Size = new Size(99, 18);
            lblEspecialista.TabIndex = 3;
            lblEspecialista.Text = "Especialista:";
            // 
            // cboEspecialista
            // 
            cboEspecialista.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialista.FormattingEnabled = true;
            cboEspecialista.Location = new Point(104, 284);
            cboEspecialista.Name = "cboEspecialista";
            cboEspecialista.Size = new Size(229, 28);
            cboEspecialista.TabIndex = 2;
            cboEspecialista.SelectionChangeCommitted += cboEspecialista_SelectionChangeCommitted;
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(104, 389);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(229, 28);
            cboCategoria.TabIndex = 3;
            cboCategoria.SelectedValueChanged += cboCategoria_SelectedValueChanged;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoria.Location = new Point(104, 357);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(87, 18);
            lblCategoria.TabIndex = 5;
            lblCategoria.Text = "Categoria:";
            // 
            // cboSubCat
            // 
            cboSubCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCat.FormattingEnabled = true;
            cboSubCat.Location = new Point(104, 494);
            cboSubCat.Name = "cboSubCat";
            cboSubCat.Size = new Size(229, 28);
            cboSubCat.TabIndex = 4;
            // 
            // lblSubCat
            // 
            lblSubCat.AutoSize = true;
            lblSubCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubCat.Location = new Point(104, 463);
            lblSubCat.Name = "lblSubCat";
            lblSubCat.Size = new Size(120, 18);
            lblSubCat.TabIndex = 7;
            lblSubCat.Text = "Sub Categoria:";
            // 
            // txtServAdc
            // 
            txtServAdc.Location = new Point(390, 178);
            txtServAdc.Name = "txtServAdc";
            txtServAdc.Size = new Size(285, 27);
            txtServAdc.TabIndex = 5;
            // 
            // lblSerAdc
            // 
            lblSerAdc.AutoSize = true;
            lblSerAdc.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSerAdc.Location = new Point(390, 148);
            lblSerAdc.Name = "lblSerAdc";
            lblSerAdc.Size = new Size(142, 18);
            lblSerAdc.TabIndex = 9;
            lblSerAdc.Text = "Servicio Adicional:";
            // 
            // txtCodigoTinte
            // 
            txtCodigoTinte.Location = new Point(390, 284);
            txtCodigoTinte.Name = "txtCodigoTinte";
            txtCodigoTinte.Size = new Size(285, 27);
            txtCodigoTinte.TabIndex = 6;
            // 
            // lblCodigoTinte
            // 
            lblCodigoTinte.AutoSize = true;
            lblCodigoTinte.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoTinte.Location = new Point(390, 254);
            lblCodigoTinte.Name = "lblCodigoTinte";
            lblCodigoTinte.Size = new Size(131, 18);
            lblCodigoTinte.TabIndex = 11;
            lblCodigoTinte.Text = "Codigo de Tinte:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(390, 389);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(131, 27);
            txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecio.Location = new Point(390, 357);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 18);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(104, 594);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(286, 64);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Agregar Servicio";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(415, 594);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(168, 64);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar Datos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblErrorCat
            // 
            lblErrorCat.AutoSize = true;
            lblErrorCat.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCat.ForeColor = Color.Red;
            lblErrorCat.Location = new Point(104, 420);
            lblErrorCat.Name = "lblErrorCat";
            lblErrorCat.Size = new Size(0, 16);
            lblErrorCat.TabIndex = 17;
            // 
            // lblErrorEspe
            // 
            lblErrorEspe.AutoSize = true;
            lblErrorEspe.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorEspe.ForeColor = Color.Red;
            lblErrorEspe.Location = new Point(104, 315);
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
            btnAtras.TabIndex = 13;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeColumns = false;
            dgvVentas.AllowUserToResizeRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.Location = new Point(700, 129);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowTemplate.Height = 29;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(889, 288);
            dgvVentas.TabIndex = 19;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrarVenta.Location = new Point(822, 440);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(238, 64);
            btnRegistrarVenta.TabIndex = 11;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.UseVisualStyleBackColor = true;
            btnRegistrarVenta.Click += btnAgregarServicio_Click;
            // 
            // btnBorraServ
            // 
            btnBorraServ.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorraServ.Location = new Point(700, 440);
            btnBorraServ.Name = "btnBorraServ";
            btnBorraServ.Size = new Size(117, 64);
            btnBorraServ.TabIndex = 10;
            btnBorraServ.Text = "Borrar Servicio";
            btnBorraServ.UseVisualStyleBackColor = true;
            btnBorraServ.Click += btnBorraServ_Click;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(531, 390);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(144, 27);
            txtPorcentaje.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(531, 359);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 23;
            label1.Text = "% de Descuento";
            // 
            // lblErrorSub
            // 
            lblErrorSub.AutoSize = true;
            lblErrorSub.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorSub.ForeColor = Color.Red;
            lblErrorSub.Location = new Point(104, 525);
            lblErrorSub.Name = "lblErrorSub";
            lblErrorSub.Size = new Size(0, 16);
            lblErrorSub.TabIndex = 24;
            // 
            // lblErrorPrecio
            // 
            lblErrorPrecio.AutoSize = true;
            lblErrorPrecio.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPrecio.ForeColor = Color.Red;
            lblErrorPrecio.Location = new Point(390, 420);
            lblErrorPrecio.Name = "lblErrorPrecio";
            lblErrorPrecio.Size = new Size(0, 16);
            lblErrorPrecio.TabIndex = 25;
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtPrecioTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPrecioTotal.Location = new Point(1445, 423);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(144, 27);
            txtPrecioTotal.TabIndex = 26;
            txtPrecioTotal.Tag = "$";
            txtPrecioTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(1325, 425);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 27;
            label2.Text = "Precio Total:";
            // 
            // txtID
            // 
            txtID.Location = new Point(238, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(171, 27);
            txtID.TabIndex = 0;
            // 
            // lblBuscaId
            // 
            lblBuscaId.AutoSize = true;
            lblBuscaId.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscaId.Location = new Point(238, 48);
            lblBuscaId.Name = "lblBuscaId";
            lblBuscaId.Size = new Size(171, 18);
            lblBuscaId.TabIndex = 29;
            lblBuscaId.Text = "Buscar Cliente por ID:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(415, 75);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(62, 29);
            btnBuscar.TabIndex = 30;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblErrorID
            // 
            lblErrorID.AutoSize = true;
            lblErrorID.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorID.ForeColor = Color.Red;
            lblErrorID.Location = new Point(238, 105);
            lblErrorID.Name = "lblErrorID";
            lblErrorID.Size = new Size(0, 16);
            lblErrorID.TabIndex = 31;
            // 
            // lblErrorPorcen
            // 
            lblErrorPorcen.AutoSize = true;
            lblErrorPorcen.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPorcen.ForeColor = Color.Red;
            lblErrorPorcen.Location = new Point(531, 421);
            lblErrorPorcen.Name = "lblErrorPorcen";
            lblErrorPorcen.Size = new Size(0, 16);
            lblErrorPorcen.TabIndex = 32;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMetodo.Location = new Point(700, 533);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(137, 18);
            lblMetodo.TabIndex = 34;
            lblMetodo.Text = "Método de pago:";
            // 
            // cboMetodo
            // 
            cboMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodo.FormattingEnabled = true;
            cboMetodo.Location = new Point(700, 565);
            cboMetodo.Name = "cboMetodo";
            cboMetodo.Size = new Size(285, 28);
            cboMetodo.TabIndex = 35;
            // 
            // frmNuevaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1631, 802);
            Controls.Add(cboMetodo);
            Controls.Add(lblMetodo);
            Controls.Add(lblErrorPorcen);
            Controls.Add(lblErrorID);
            Controls.Add(btnBuscar);
            Controls.Add(lblBuscaId);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(txtPrecioTotal);
            Controls.Add(lblErrorPrecio);
            Controls.Add(lblErrorSub);
            Controls.Add(label1);
            Controls.Add(txtPorcentaje);
            Controls.Add(btnBorraServ);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(dgvVentas);
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
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
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
        private DataGridView dgvVentas;
        private Button btnRegistrarVenta;
        private Button btnBorraServ;
        private TextBox txtPorcentaje;
        private Label label1;
        private Label lblErrorSub;
        private Label lblErrorPrecio;
        private TextBox txtPrecioTotal;
        private Label label2;
        private TextBox txtID;
        private Label lblBuscaId;
        private Button btnBuscar;
        private Label lblErrorID;
        private Label lblErrorPorcen;
        private Label lblMetodo;
        private ComboBox cboMetodo;
    }
}