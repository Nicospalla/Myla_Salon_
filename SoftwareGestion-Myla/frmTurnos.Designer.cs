namespace SoftwareGestion_Myla
{
    partial class frmTurnos
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
            calendarTurno = new MonthCalendar();
            btnNuevo = new Button();
            pnlEdit = new Panel();
            lblErrorEstado = new Label();
            cboEstado = new ComboBox();
            lblEstado = new Label();
            lblErrorEsp = new Label();
            lblErrorSubCat = new Label();
            lblTitulo = new Label();
            lblErrorHora = new Label();
            btnAtras = new Button();
            lblErrorId = new Label();
            btnBuscar = new Button();
            txtNombre = new TextBox();
            lblHorario = new Label();
            cboHorarios = new ComboBox();
            label3 = new Label();
            cboEspe = new ComboBox();
            label2 = new Label();
            cboSubCat = new ComboBox();
            label1 = new Label();
            txtIdCliente = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblNombre = new Label();
            pnlGrid = new Panel();
            lblNombreEsp = new Label();
            lblFecha = new Label();
            dgvTurnos = new DataGridView();
            btnModif = new Button();
            btnEliminar = new Button();
            label4 = new Label();
            cboEspeVerTurnos = new ComboBox();
            btnTurnoReservado = new Button();
            pnlEdit.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // calendarTurno
            // 
            calendarTurno.Location = new Point(18, 33);
            calendarTurno.MaxSelectionCount = 1;
            calendarTurno.Name = "calendarTurno";
            calendarTurno.TabIndex = 7;
            calendarTurno.DateChanged += calendarTurno_DateChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(18, 434);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(290, 68);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo Turno";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(lblErrorEstado);
            pnlEdit.Controls.Add(cboEstado);
            pnlEdit.Controls.Add(lblEstado);
            pnlEdit.Controls.Add(lblErrorEsp);
            pnlEdit.Controls.Add(lblErrorSubCat);
            pnlEdit.Controls.Add(lblTitulo);
            pnlEdit.Controls.Add(lblErrorHora);
            pnlEdit.Controls.Add(btnAtras);
            pnlEdit.Controls.Add(lblErrorId);
            pnlEdit.Controls.Add(btnBuscar);
            pnlEdit.Controls.Add(txtNombre);
            pnlEdit.Controls.Add(lblHorario);
            pnlEdit.Controls.Add(cboHorarios);
            pnlEdit.Controls.Add(label3);
            pnlEdit.Controls.Add(cboEspe);
            pnlEdit.Controls.Add(label2);
            pnlEdit.Controls.Add(cboSubCat);
            pnlEdit.Controls.Add(label1);
            pnlEdit.Controls.Add(txtIdCliente);
            pnlEdit.Controls.Add(btnCancelar);
            pnlEdit.Controls.Add(btnGuardar);
            pnlEdit.Controls.Add(lblNombre);
            pnlEdit.Location = new Point(333, 44);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(916, 659);
            pnlEdit.TabIndex = 9;
            // 
            // lblErrorEstado
            // 
            lblErrorEstado.AutoSize = true;
            lblErrorEstado.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEstado.ForeColor = Color.Red;
            lblErrorEstado.Location = new Point(533, 364);
            lblErrorEstado.Name = "lblErrorEstado";
            lblErrorEstado.Size = new Size(0, 16);
            lblErrorEstado.TabIndex = 24;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(533, 333);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(290, 28);
            cboEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.Location = new Point(533, 312);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 18);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "Estado:";
            // 
            // lblErrorEsp
            // 
            lblErrorEsp.AutoSize = true;
            lblErrorEsp.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEsp.ForeColor = Color.Red;
            lblErrorEsp.Location = new Point(108, 370);
            lblErrorEsp.Name = "lblErrorEsp";
            lblErrorEsp.Size = new Size(0, 16);
            lblErrorEsp.TabIndex = 21;
            // 
            // lblErrorSubCat
            // 
            lblErrorSubCat.AutoSize = true;
            lblErrorSubCat.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorSubCat.ForeColor = Color.Red;
            lblErrorSubCat.Location = new Point(533, 182);
            lblErrorSubCat.Name = "lblErrorSubCat";
            lblErrorSubCat.Size = new Size(0, 16);
            lblErrorSubCat.TabIndex = 20;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(108, 70);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 18);
            lblTitulo.TabIndex = 18;
            // 
            // lblErrorHora
            // 
            lblErrorHora.AutoSize = true;
            lblErrorHora.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorHora.ForeColor = Color.Red;
            lblErrorHora.Location = new Point(533, 276);
            lblErrorHora.Name = "lblErrorHora";
            lblErrorHora.Size = new Size(0, 16);
            lblErrorHora.TabIndex = 19;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(3, 3);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(60, 60);
            btnAtras.TabIndex = 13;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblErrorId
            // 
            lblErrorId.AccessibleRole = AccessibleRole.None;
            lblErrorId.AutoSize = true;
            lblErrorId.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorId.ForeColor = Color.Red;
            lblErrorId.Location = new Point(108, 182);
            lblErrorId.Name = "lblErrorId";
            lblErrorId.Size = new Size(0, 16);
            lblErrorId.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(258, 150);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 240);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 27);
            txtNombre.TabIndex = 8;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.Location = new Point(533, 219);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(70, 18);
            lblHorario.TabIndex = 7;
            lblHorario.Text = "Horario:";
            // 
            // cboHorarios
            // 
            cboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(533, 240);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(290, 28);
            cboHorarios.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(108, 318);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 5;
            label3.Text = "Especialista:";
            // 
            // cboEspe
            // 
            cboEspe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspe.FormattingEnabled = true;
            cboEspe.Location = new Point(108, 339);
            cboEspe.Name = "cboEspe";
            cboEspe.Size = new Size(290, 28);
            cboEspe.TabIndex = 4;
            cboEspe.SelectionChangeCommitted += cboEspe_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(533, 129);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 3;
            label2.Text = "SubCategoria:";
            // 
            // cboSubCat
            // 
            cboSubCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCat.FormattingEnabled = true;
            cboSubCat.Location = new Point(533, 150);
            cboSubCat.Name = "cboSubCat";
            cboSubCat.Size = new Size(290, 28);
            cboSubCat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(108, 121);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 1;
            label1.Text = "Nro de Cliente:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.AccessibleRole = AccessibleRole.None;
            txtIdCliente.Location = new Point(108, 151);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(140, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(482, 449);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(208, 69);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(247, 449);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(208, 68);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(108, 219);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(153, 18);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre de Cliente:";
            // 
            // pnlGrid
            // 
            pnlGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGrid.Controls.Add(lblNombreEsp);
            pnlGrid.Controls.Add(lblFecha);
            pnlGrid.Controls.Add(dgvTurnos);
            pnlGrid.Controls.Add(btnModif);
            pnlGrid.Controls.Add(btnEliminar);
            pnlGrid.Location = new Point(314, 33);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(1073, 705);
            pnlGrid.TabIndex = 18;
            // 
            // lblNombreEsp
            // 
            lblNombreEsp.AutoSize = true;
            lblNombreEsp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreEsp.Location = new Point(38, 66);
            lblNombreEsp.Name = "lblNombreEsp";
            lblNombreEsp.Size = new Size(199, 18);
            lblNombreEsp.TabIndex = 7;
            lblNombreEsp.Text = "Especialista seleccionado:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblFecha.Location = new Point(38, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 18);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeColumns = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTurnos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTurnos.Location = new Point(39, 104);
            dgvTurnos.MultiSelect = false;
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.RowTemplate.Height = 29;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(1021, 520);
            dgvTurnos.TabIndex = 5;
            dgvTurnos.ColumnHeaderMouseClick += dgvTurnos_ColumnHeaderMouseClick;
            // 
            // btnModif
            // 
            btnModif.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnModif.Location = new Point(39, 631);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(290, 68);
            btnModif.TabIndex = 0;
            btnModif.Text = "Modificar Turno";
            btnModif.UseVisualStyleBackColor = true;
            btnModif.Click += btnModif_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnEliminar.Location = new Point(358, 631);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(290, 68);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar Turno";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 252);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 15;
            label4.Text = "Especialista:";
            // 
            // cboEspeVerTurnos
            // 
            cboEspeVerTurnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspeVerTurnos.FormattingEnabled = true;
            cboEspeVerTurnos.Location = new Point(18, 273);
            cboEspeVerTurnos.Name = "cboEspeVerTurnos";
            cboEspeVerTurnos.Size = new Size(290, 28);
            cboEspeVerTurnos.TabIndex = 0;
            cboEspeVerTurnos.SelectedIndexChanged += cboEspeVerTurnos_SelectedIndexChanged;
            // 
            // btnTurnoReservado
            // 
            btnTurnoReservado.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTurnoReservado.Location = new Point(18, 320);
            btnTurnoReservado.Name = "btnTurnoReservado";
            btnTurnoReservado.Size = new Size(290, 68);
            btnTurnoReservado.TabIndex = 1;
            btnTurnoReservado.Text = "Ver Turnos Reservados";
            btnTurnoReservado.UseVisualStyleBackColor = true;
            btnTurnoReservado.Click += btnTurnoReservado_Click;
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(800, 800);
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1399, 884);
            Controls.Add(pnlGrid);
            Controls.Add(btnTurnoReservado);
            Controls.Add(label4);
            Controls.Add(cboEspeVerTurnos);
            Controls.Add(btnNuevo);
            Controls.Add(calendarTurno);
            Controls.Add(pnlEdit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTurnos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmTurnos";
            Load += frmTurnos_Load;
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MonthCalendar calendarTurno;
        private Button btnNuevo;
        private Panel pnlEdit;
        private Button btnModif;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtIdCliente;
        private Label label2;
        private ComboBox cboSubCat;
        private Label label3;
        private ComboBox cboEspe;
        private ComboBox cboHorarios;
        private Label lblHorario;
        private Button btnBuscar;
        private TextBox txtNombre;
        private Label lblErrorId;
        private Label lblNombre;
        private Button btnAtras;
        private Label label4;
        private ComboBox cboEspeVerTurnos;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnTurnoReservado;
        private Panel pnlGrid;
        private Label lblFecha;
        private Label lblNombreEsp;
        private Label lblTitulo;
        private Label lblErrorEsp;
        private Label lblErrorSubCat;
        private Label lblErrorHora;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Label lblErrorEstado;
        public DataGridView dgvTurnos;
    }
}