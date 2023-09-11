namespace SoftwareGestion_Myla
{
    partial class frmFinanzas
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
            calendarFecha = new MonthCalendar();
            btnAtras = new Button();
            dataGridHisto = new DataGridView();
            cboEspe = new ComboBox();
            lblEspe = new Label();
            txtSueldo = new TextBox();
            lblSueldo = new Label();
            lblComi = new Label();
            rbCalendar = new RadioButton();
            rbDosFechas = new RadioButton();
            pnlCalendario = new Panel();
            pnlFechas = new Panel();
            label3 = new Label();
            lblFechaInicio = new Label();
            dateTime2 = new DateTimePicker();
            dateTime1 = new DateTimePicker();
            lblResta = new Label();
            txtResta = new TextBox();
            txtComi = new TextBox();
            lblCostoFijo = new Label();
            txtCostoFijo = new TextBox();
            lblFijo2 = new Label();
            txtSueldo2 = new TextBox();
            lblComi2 = new Label();
            txtComi2 = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridHisto).BeginInit();
            pnlCalendario.SuspendLayout();
            pnlFechas.SuspendLayout();
            SuspendLayout();
            // 
            // calendarFecha
            // 
            calendarFecha.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calendarFecha.Location = new Point(14, 24);
            calendarFecha.MaxSelectionCount = 31;
            calendarFecha.Name = "calendarFecha";
            calendarFecha.TabIndex = 0;
            calendarFecha.DateSelected += calendarFecha_DateSelected;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(74, 68);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // dataGridHisto
            // 
            dataGridHisto.AllowUserToAddRows = false;
            dataGridHisto.AllowUserToDeleteRows = false;
            dataGridHisto.AllowUserToOrderColumns = true;
            dataGridHisto.AllowUserToResizeColumns = false;
            dataGridHisto.AllowUserToResizeRows = false;
            dataGridHisto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHisto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHisto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHisto.Location = new Point(436, 176);
            dataGridHisto.MultiSelect = false;
            dataGridHisto.Name = "dataGridHisto";
            dataGridHisto.ReadOnly = true;
            dataGridHisto.RowHeadersVisible = false;
            dataGridHisto.RowHeadersWidth = 51;
            dataGridHisto.RowTemplate.Height = 29;
            dataGridHisto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHisto.Size = new Size(922, 363);
            dataGridHisto.TabIndex = 2;
            // 
            // cboEspe
            // 
            cboEspe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspe.FormattingEnabled = true;
            cboEspe.Location = new Point(83, 500);
            cboEspe.Name = "cboEspe";
            cboEspe.Size = new Size(290, 28);
            cboEspe.TabIndex = 3;
            cboEspe.SelectionChangeCommitted += cboEspe_SelectionChangeCommitted;
            // 
            // lblEspe
            // 
            lblEspe.AutoSize = true;
            lblEspe.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspe.Location = new Point(83, 470);
            lblEspe.Name = "lblEspe";
            lblEspe.Size = new Size(99, 18);
            lblEspe.TabIndex = 4;
            lblEspe.Text = "Especialista:";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(83, 592);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(291, 27);
            txtSueldo.TabIndex = 5;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSueldo.Location = new Point(83, 561);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(97, 18);
            lblSueldo.TabIndex = 6;
            lblSueldo.Text = "Sueldo Fijo:";
            // 
            // lblComi
            // 
            lblComi.AutoSize = true;
            lblComi.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComi.Location = new Point(83, 650);
            lblComi.Name = "lblComi";
            lblComi.Size = new Size(84, 18);
            lblComi.TabIndex = 8;
            lblComi.Text = "Comisión:";
            // 
            // rbCalendar
            // 
            rbCalendar.AutoSize = true;
            rbCalendar.Location = new Point(99, 146);
            rbCalendar.Name = "rbCalendar";
            rbCalendar.Size = new Size(102, 24);
            rbCalendar.TabIndex = 9;
            rbCalendar.TabStop = true;
            rbCalendar.Text = "Calendario";
            rbCalendar.UseVisualStyleBackColor = true;
            rbCalendar.CheckedChanged += rbCalendar_CheckedChanged;
            // 
            // rbDosFechas
            // 
            rbDosFechas.AutoSize = true;
            rbDosFechas.Location = new Point(251, 146);
            rbDosFechas.Name = "rbDosFechas";
            rbDosFechas.Size = new Size(138, 24);
            rbDosFechas.TabIndex = 10;
            rbDosFechas.TabStop = true;
            rbDosFechas.Text = "Entre dos fechas";
            rbDosFechas.UseVisualStyleBackColor = true;
            // 
            // pnlCalendario
            // 
            pnlCalendario.Controls.Add(calendarFecha);
            pnlCalendario.Location = new Point(86, 176);
            pnlCalendario.Name = "pnlCalendario";
            pnlCalendario.Size = new Size(319, 240);
            pnlCalendario.TabIndex = 11;
            // 
            // pnlFechas
            // 
            pnlFechas.Controls.Add(label3);
            pnlFechas.Controls.Add(lblFechaInicio);
            pnlFechas.Controls.Add(dateTime2);
            pnlFechas.Controls.Add(dateTime1);
            pnlFechas.Location = new Point(83, 166);
            pnlFechas.Name = "pnlFechas";
            pnlFechas.Size = new Size(319, 264);
            pnlFechas.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 13;
            label3.Text = "Fecha de Fin:";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaInicio.Location = new Point(13, 40);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(125, 18);
            lblFechaInicio.TabIndex = 12;
            lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dateTime2
            // 
            dateTime2.Location = new Point(15, 146);
            dateTime2.Name = "dateTime2";
            dateTime2.Size = new Size(289, 27);
            dateTime2.TabIndex = 1;
            dateTime2.ValueChanged += dateTime2_ValueChanged;
            // 
            // dateTime1
            // 
            dateTime1.Location = new Point(15, 61);
            dateTime1.Name = "dateTime1";
            dateTime1.Size = new Size(289, 27);
            dateTime1.TabIndex = 0;
            dateTime1.ValueChanged += dateTime1_ValueChanged;
            // 
            // lblResta
            // 
            lblResta.AutoSize = true;
            lblResta.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblResta.Location = new Point(1066, 650);
            lblResta.Name = "lblResta";
            lblResta.Size = new Size(104, 18);
            lblResta.TabIndex = 14;
            lblResta.Text = "Resta pagar:";
            // 
            // txtResta
            // 
            txtResta.Location = new Point(1066, 681);
            txtResta.Name = "txtResta";
            txtResta.ReadOnly = true;
            txtResta.Size = new Size(291, 27);
            txtResta.TabIndex = 13;
            // 
            // txtComi
            // 
            txtComi.Location = new Point(83, 681);
            txtComi.Name = "txtComi";
            txtComi.ReadOnly = true;
            txtComi.Size = new Size(291, 27);
            txtComi.TabIndex = 7;
            // 
            // lblCostoFijo
            // 
            lblCostoFijo.AutoSize = true;
            lblCostoFijo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCostoFijo.Location = new Point(435, 650);
            lblCostoFijo.Name = "lblCostoFijo";
            lblCostoFijo.Size = new Size(146, 18);
            lblCostoFijo.TabIndex = 16;
            lblCostoFijo.Text = "Costo fijo: (en %)";
            // 
            // txtCostoFijo
            // 
            txtCostoFijo.Location = new Point(435, 681);
            txtCostoFijo.Name = "txtCostoFijo";
            txtCostoFijo.Size = new Size(146, 27);
            txtCostoFijo.TabIndex = 15;
            txtCostoFijo.TextChanged += txtCostoFijo_TextChanged;
            // 
            // lblFijo2
            // 
            lblFijo2.AutoSize = true;
            lblFijo2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFijo2.Location = new Point(607, 650);
            lblFijo2.Name = "lblFijo2";
            lblFijo2.Size = new Size(97, 18);
            lblFijo2.TabIndex = 18;
            lblFijo2.Text = "Sueldo Fijo:";
            // 
            // txtSueldo2
            // 
            txtSueldo2.Location = new Point(607, 681);
            txtSueldo2.Name = "txtSueldo2";
            txtSueldo2.ReadOnly = true;
            txtSueldo2.Size = new Size(146, 27);
            txtSueldo2.TabIndex = 17;
            // 
            // lblComi2
            // 
            lblComi2.AutoSize = true;
            lblComi2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblComi2.Location = new Point(779, 650);
            lblComi2.Name = "lblComi2";
            lblComi2.Size = new Size(84, 18);
            lblComi2.TabIndex = 20;
            lblComi2.Text = "Comisión:";
            // 
            // txtComi2
            // 
            txtComi2.Location = new Point(779, 681);
            txtComi2.Name = "txtComi2";
            txtComi2.ReadOnly = true;
            txtComi2.Size = new Size(146, 27);
            txtComi2.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(436, 561);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(138, 18);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "Total facturado:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(436, 592);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(291, 27);
            txtTotal.TabIndex = 21;
            // 
            // frmFinanzas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 782);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(lblComi2);
            Controls.Add(txtComi2);
            Controls.Add(lblFijo2);
            Controls.Add(txtSueldo2);
            Controls.Add(lblCostoFijo);
            Controls.Add(txtCostoFijo);
            Controls.Add(lblResta);
            Controls.Add(pnlFechas);
            Controls.Add(txtResta);
            Controls.Add(rbDosFechas);
            Controls.Add(rbCalendar);
            Controls.Add(lblComi);
            Controls.Add(txtComi);
            Controls.Add(lblSueldo);
            Controls.Add(txtSueldo);
            Controls.Add(lblEspe);
            Controls.Add(cboEspe);
            Controls.Add(dataGridHisto);
            Controls.Add(btnAtras);
            Controls.Add(pnlCalendario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFinanzas";
            Text = "frmFinanzas";
            Load += frmFinanzas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHisto).EndInit();
            pnlCalendario.ResumeLayout(false);
            pnlFechas.ResumeLayout(false);
            pnlFechas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarFecha;
        private Button btnAtras;
        private DataGridView dataGridHisto;
        private ComboBox cboEspe;
        private Label lblEspe;
        private TextBox txtSueldo;
        private Label lblSueldo;
        private Label lblComi;
        private RadioButton rbCalendar;
        private RadioButton rbDosFechas;
        private Panel pnlCalendario;
        private Panel pnlFechas;
        private Label label3;
        private Label lblFechaInicio;
        private DateTimePicker dateTime2;
        private DateTimePicker dateTime1;
        private Label lblResta;
        private TextBox txtResta;
        private TextBox txtComi;
        private Label lblCostoFijo;
        private TextBox txtCostoFijo;
        private Label lblFijo2;
        private TextBox txtSueldo2;
        private Label lblComi2;
        private TextBox txtComi2;
        private Label lblTotal;
        private TextBox txtTotal;
    }
}