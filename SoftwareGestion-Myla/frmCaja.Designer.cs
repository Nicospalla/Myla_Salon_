namespace SoftwareGestion_Myla
{
    partial class frmCaja
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
            calendar = new MonthCalendar();
            txtRetiro = new TextBox();
            txtPagoProv = new TextBox();
            txtIngreso = new TextBox();
            lblNombreProv = new Label();
            txtNombreProv = new TextBox();
            dgvCaja = new DataGridView();
            btnAtras = new Button();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            rbRetiro = new RadioButton();
            rbPago = new RadioButton();
            rbIngreso = new RadioButton();
            lblTitulo = new Label();
            rbCambioCaja = new RadioButton();
            txtCaja = new TextBox();
            btnGuardar = new Button();
            rbIngresoEft = new RadioButton();
            rbEgresoEft = new RadioButton();
            panel1 = new Panel();
            lblAviso = new Label();
            lblFecha = new Label();
            txtFecha = new TextBox();
            lblApertura = new Label();
            txtApertura = new TextBox();
            lblIngresos = new Label();
            txtIngresos = new TextBox();
            lblPagos = new Label();
            txtPagos = new TextBox();
            lblRetiro = new Label();
            txtRetiros = new TextBox();
            lblTotalEft = new Label();
            txtTotalEft = new TextBox();
            lblTotalTarj = new Label();
            txtTotalTarj = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            panel2 = new Panel();
            lblErrorCaja = new Label();
            lblErrorIngreso = new Label();
            lblErrorRetiro = new Label();
            lblErrorPago = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // calendar
            // 
            calendar.Location = new Point(66, 92);
            calendar.Name = "calendar";
            calendar.TabIndex = 0;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // txtRetiro
            // 
            txtRetiro.Location = new Point(112, 646);
            txtRetiro.Name = "txtRetiro";
            txtRetiro.Size = new Size(202, 27);
            txtRetiro.TabIndex = 1;
            // 
            // txtPagoProv
            // 
            txtPagoProv.Location = new Point(112, 730);
            txtPagoProv.Name = "txtPagoProv";
            txtPagoProv.Size = new Size(202, 27);
            txtPagoProv.TabIndex = 3;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(112, 557);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(202, 27);
            txtIngreso.TabIndex = 5;
            // 
            // lblNombreProv
            // 
            lblNombreProv.AutoSize = true;
            lblNombreProv.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProv.Location = new Point(333, 707);
            lblNombreProv.Name = "lblNombreProv";
            lblNombreProv.Size = new Size(157, 18);
            lblNombreProv.TabIndex = 8;
            lblNombreProv.Text = "Nombre proveedor:";
            // 
            // txtNombreProv
            // 
            txtNombreProv.Location = new Point(333, 730);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.Size = new Size(202, 27);
            txtNombreProv.TabIndex = 7;
            // 
            // dgvCaja
            // 
            dgvCaja.AllowUserToAddRows = false;
            dgvCaja.AllowUserToDeleteRows = false;
            dgvCaja.AllowUserToOrderColumns = true;
            dgvCaja.AllowUserToResizeColumns = false;
            dgvCaja.AllowUserToResizeRows = false;
            dgvCaja.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Location = new Point(368, 117);
            dgvCaja.MultiSelect = false;
            dgvCaja.Name = "dgvCaja";
            dgvCaja.ReadOnly = true;
            dgvCaja.RowHeadersVisible = false;
            dgvCaja.RowHeadersWidth = 51;
            dgvCaja.RowTemplate.Height = 29;
            dgvCaja.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaja.Size = new Size(991, 305);
            dgvCaja.TabIndex = 9;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(74, 68);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblMotivo.Location = new Point(333, 623);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(66, 18);
            lblMotivo.TabIndex = 12;
            lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(333, 646);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(202, 27);
            txtMotivo.TabIndex = 11;
            // 
            // rbRetiro
            // 
            rbRetiro.AutoSize = true;
            rbRetiro.Location = new Point(112, 620);
            rbRetiro.Name = "rbRetiro";
            rbRetiro.Size = new Size(151, 24);
            rbRetiro.TabIndex = 14;
            rbRetiro.TabStop = true;
            rbRetiro.Text = "Retiro de efectivo:";
            rbRetiro.UseVisualStyleBackColor = true;
            rbRetiro.CheckedChanged += rbRetiro_CheckedChanged;
            // 
            // rbPago
            // 
            rbPago.AutoSize = true;
            rbPago.Location = new Point(112, 704);
            rbPago.Name = "rbPago";
            rbPago.Size = new Size(153, 24);
            rbPago.TabIndex = 15;
            rbPago.TabStop = true;
            rbPago.Text = "Pago proveedores:";
            rbPago.UseVisualStyleBackColor = true;
            rbPago.CheckedChanged += rbPago_CheckedChanged;
            // 
            // rbIngreso
            // 
            rbIngreso.AutoSize = true;
            rbIngreso.Location = new Point(112, 527);
            rbIngreso.Name = "rbIngreso";
            rbIngreso.Size = new Size(160, 24);
            rbIngreso.TabIndex = 16;
            rbIngreso.TabStop = true;
            rbIngreso.Text = "Ingreso de efectivo:";
            rbIngreso.UseVisualStyleBackColor = true;
            rbIngreso.CheckedChanged += rbIngreso_CheckedChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(112, 402);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(240, 20);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Seleccione la operación:";
            // 
            // rbCambioCaja
            // 
            rbCambioCaja.AutoSize = true;
            rbCambioCaja.Location = new Point(112, 439);
            rbCambioCaja.Name = "rbCambioCaja";
            rbCambioCaja.Size = new Size(181, 24);
            rbCambioCaja.TabIndex = 18;
            rbCambioCaja.TabStop = true;
            rbCambioCaja.Text = "Modificar caja INICIAL:";
            rbCambioCaja.UseVisualStyleBackColor = true;
            rbCambioCaja.CheckedChanged += rbCambioCaja_CheckedChanged;
            // 
            // txtCaja
            // 
            txtCaja.Location = new Point(112, 468);
            txtCaja.Name = "txtCaja";
            txtCaja.Size = new Size(202, 27);
            txtCaja.TabIndex = 19;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(112, 791);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(202, 62);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // rbIngresoEft
            // 
            rbIngresoEft.AutoSize = true;
            rbIngresoEft.Location = new Point(15, 14);
            rbIngresoEft.Name = "rbIngresoEft";
            rbIngresoEft.Size = new Size(85, 24);
            rbIngresoEft.TabIndex = 23;
            rbIngresoEft.TabStop = true;
            rbIngresoEft.Text = "Ingresos";
            rbIngresoEft.UseVisualStyleBackColor = true;
            rbIngresoEft.CheckedChanged += rbIngresoEft_CheckedChanged;
            // 
            // rbEgresoEft
            // 
            rbEgresoEft.AutoSize = true;
            rbEgresoEft.Location = new Point(149, 14);
            rbEgresoEft.Name = "rbEgresoEft";
            rbEgresoEft.Size = new Size(81, 24);
            rbEgresoEft.TabIndex = 24;
            rbEgresoEft.TabStop = true;
            rbEgresoEft.Text = "Egresos";
            rbEgresoEft.UseVisualStyleBackColor = true;
            rbEgresoEft.CheckedChanged += rbEgresoEft_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbIngresoEft);
            panel1.Controls.Add(rbEgresoEft);
            panel1.Location = new Point(368, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 41);
            panel1.TabIndex = 25;
            // 
            // lblAviso
            // 
            lblAviso.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAviso.Location = new Point(815, 92);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(544, 18);
            lblAviso.TabIndex = 26;
            lblAviso.Text = "Los registros de caja se eliminan automaticamente pasados los 90 días.";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(37, 19);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 18);
            lblFecha.TabIndex = 28;
            lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(37, 42);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(202, 27);
            txtFecha.TabIndex = 27;
            // 
            // lblApertura
            // 
            lblApertura.AutoSize = true;
            lblApertura.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblApertura.Location = new Point(37, 108);
            lblApertura.Name = "lblApertura";
            lblApertura.Size = new Size(138, 18);
            lblApertura.TabIndex = 30;
            lblApertura.Text = "Apertura de caja:";
            // 
            // txtApertura
            // 
            txtApertura.Location = new Point(37, 131);
            txtApertura.Name = "txtApertura";
            txtApertura.Size = new Size(202, 27);
            txtApertura.TabIndex = 29;
            // 
            // lblIngresos
            // 
            lblIngresos.AutoSize = true;
            lblIngresos.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIngresos.Location = new Point(37, 192);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(79, 18);
            lblIngresos.TabIndex = 32;
            lblIngresos.Text = "Ingresos:";
            // 
            // txtIngresos
            // 
            txtIngresos.Location = new Point(37, 215);
            txtIngresos.Name = "txtIngresos";
            txtIngresos.Size = new Size(202, 27);
            txtIngresos.TabIndex = 31;
            // 
            // lblPagos
            // 
            lblPagos.AutoSize = true;
            lblPagos.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagos.Location = new Point(37, 281);
            lblPagos.Name = "lblPagos";
            lblPagos.Size = new Size(60, 18);
            lblPagos.TabIndex = 34;
            lblPagos.Text = "Pagos:";
            // 
            // txtPagos
            // 
            txtPagos.Location = new Point(37, 304);
            txtPagos.Name = "txtPagos";
            txtPagos.Size = new Size(202, 27);
            txtPagos.TabIndex = 33;
            // 
            // lblRetiro
            // 
            lblRetiro.AutoSize = true;
            lblRetiro.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRetiro.Location = new Point(307, 19);
            lblRetiro.Name = "lblRetiro";
            lblRetiro.Size = new Size(154, 18);
            lblRetiro.TabIndex = 36;
            lblRetiro.Text = "Retiros de efectivo:";
            // 
            // txtRetiros
            // 
            txtRetiros.Location = new Point(307, 42);
            txtRetiros.Name = "txtRetiros";
            txtRetiros.Size = new Size(202, 27);
            txtRetiros.TabIndex = 35;
            // 
            // lblTotalEft
            // 
            lblTotalEft.AutoSize = true;
            lblTotalEft.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalEft.Location = new Point(307, 108);
            lblTotalEft.Name = "lblTotalEft";
            lblTotalEft.Size = new Size(173, 18);
            lblTotalEft.TabIndex = 38;
            lblTotalEft.Text = "Total efectivo en caja:";
            // 
            // txtTotalEft
            // 
            txtTotalEft.Location = new Point(307, 131);
            txtTotalEft.Name = "txtTotalEft";
            txtTotalEft.Size = new Size(202, 27);
            txtTotalEft.TabIndex = 37;
            // 
            // lblTotalTarj
            // 
            lblTotalTarj.AutoSize = true;
            lblTotalTarj.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalTarj.Location = new Point(307, 192);
            lblTotalTarj.Name = "lblTotalTarj";
            lblTotalTarj.Size = new Size(105, 18);
            lblTotalTarj.TabIndex = 40;
            lblTotalTarj.Text = "Total tarjeta:";
            // 
            // txtTotalTarj
            // 
            txtTotalTarj.Location = new Point(307, 215);
            txtTotalTarj.Name = "txtTotalTarj";
            txtTotalTarj.Size = new Size(202, 27);
            txtTotalTarj.TabIndex = 39;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(307, 281);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(102, 18);
            lblTotal.TabIndex = 42;
            lblTotal.Text = "Total del dia:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(307, 304);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(202, 27);
            txtTotal.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(txtFecha);
            panel2.Controls.Add(txtTotal);
            panel2.Controls.Add(lblFecha);
            panel2.Controls.Add(lblTotalTarj);
            panel2.Controls.Add(txtApertura);
            panel2.Controls.Add(txtTotalTarj);
            panel2.Controls.Add(lblApertura);
            panel2.Controls.Add(lblTotalEft);
            panel2.Controls.Add(txtIngresos);
            panel2.Controls.Add(txtTotalEft);
            panel2.Controls.Add(lblIngresos);
            panel2.Controls.Add(lblRetiro);
            panel2.Controls.Add(txtPagos);
            panel2.Controls.Add(txtRetiros);
            panel2.Controls.Add(lblPagos);
            panel2.Location = new Point(681, 457);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 351);
            panel2.TabIndex = 43;
            // 
            // lblErrorCaja
            // 
            lblErrorCaja.AutoSize = true;
            lblErrorCaja.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorCaja.ForeColor = Color.Red;
            lblErrorCaja.Location = new Point(112, 498);
            lblErrorCaja.Name = "lblErrorCaja";
            lblErrorCaja.Size = new Size(45, 16);
            lblErrorCaja.TabIndex = 44;
            lblErrorCaja.Text = "label1";
            // 
            // lblErrorIngreso
            // 
            lblErrorIngreso.AutoSize = true;
            lblErrorIngreso.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorIngreso.ForeColor = Color.Red;
            lblErrorIngreso.Location = new Point(112, 587);
            lblErrorIngreso.Name = "lblErrorIngreso";
            lblErrorIngreso.Size = new Size(45, 16);
            lblErrorIngreso.TabIndex = 45;
            lblErrorIngreso.Text = "label2";
            // 
            // lblErrorRetiro
            // 
            lblErrorRetiro.AutoSize = true;
            lblErrorRetiro.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorRetiro.ForeColor = Color.Red;
            lblErrorRetiro.Location = new Point(112, 676);
            lblErrorRetiro.Name = "lblErrorRetiro";
            lblErrorRetiro.Size = new Size(45, 16);
            lblErrorRetiro.TabIndex = 46;
            lblErrorRetiro.Text = "label3";
            // 
            // lblErrorPago
            // 
            lblErrorPago.AutoSize = true;
            lblErrorPago.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPago.ForeColor = Color.Red;
            lblErrorPago.Location = new Point(112, 760);
            lblErrorPago.Name = "lblErrorPago";
            lblErrorPago.Size = new Size(45, 16);
            lblErrorPago.TabIndex = 47;
            lblErrorPago.Text = "label4";
            // 
            // frmCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1391, 885);
            Controls.Add(lblErrorPago);
            Controls.Add(lblErrorRetiro);
            Controls.Add(lblErrorIngreso);
            Controls.Add(lblErrorCaja);
            Controls.Add(lblAviso);
            Controls.Add(panel1);
            Controls.Add(btnGuardar);
            Controls.Add(txtCaja);
            Controls.Add(rbCambioCaja);
            Controls.Add(lblTitulo);
            Controls.Add(rbIngreso);
            Controls.Add(rbPago);
            Controls.Add(rbRetiro);
            Controls.Add(lblMotivo);
            Controls.Add(txtMotivo);
            Controls.Add(btnAtras);
            Controls.Add(dgvCaja);
            Controls.Add(lblNombreProv);
            Controls.Add(txtNombreProv);
            Controls.Add(txtIngreso);
            Controls.Add(txtPagoProv);
            Controls.Add(txtRetiro);
            Controls.Add(calendar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCaja";
            Text = "frmCaja";
            Load += frmCaja_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendar;
        private TextBox txtRetiro;
        private TextBox txtPagoProv;
        private Label lblIngreso;
        private TextBox txtIngreso;
        private Label lblNombreProv;
        private TextBox txtNombreProv;
        private DataGridView dgvCaja;
        private Button btnAtras;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private RadioButton rbRetiro;
        private RadioButton rbPago;
        private RadioButton rbIngreso;
        private Label lblTitulo;
        private RadioButton rbCambioCaja;
        private TextBox txtCaja;
        private Button btnGuardar;
        private RadioButton rbIngresoEft;
        private RadioButton rbEgresoEft;
        private Panel panel1;
        private Label lblAviso;
        private Label lblFecha;
        private TextBox txtFecha;
        private Label lblApertura;
        private TextBox txtApertura;
        private Label lblIngresos;
        private TextBox txtIngresos;
        private Label lblPagos;
        private TextBox txtPagos;
        private Label lblRetiro;
        private TextBox txtRetiros;
        private Label lblTotalEft;
        private TextBox txtTotalEft;
        private Label lblTotalTarj;
        private TextBox txtTotalTarj;
        private Label lblTotal;
        private TextBox txtTotal;
        private Panel panel2;
        private Label lblErrorCaja;
        private Label lblErrorIngreso;
        private Label lblErrorRetiro;
        private Label lblErrorPago;
    }
}