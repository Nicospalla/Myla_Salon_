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
            btnModif = new Button();
            btnEliminar = new Button();
            btnVerTurnos = new Button();
            label4 = new Label();
            cboEspeVerTurnos = new ComboBox();
            button1 = new Button();
            pnlGrid = new Panel();
            dgvTurnos = new DataGridView();
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
            calendarTurno.ShowTodayCircle = false;
            calendarTurno.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.Location = new Point(18, 381);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(290, 68);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo Turno";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pnlEdit
            // 
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
            pnlEdit.Location = new Point(421, 61);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Size = new Size(550, 603);
            pnlEdit.TabIndex = 9;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(32, 40);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(60, 60);
            btnAtras.TabIndex = 13;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblErrorId
            // 
            lblErrorId.AutoSize = true;
            lblErrorId.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorId.ForeColor = Color.Red;
            lblErrorId.Location = new Point(166, 175);
            lblErrorId.Name = "lblErrorId";
            lblErrorId.Size = new Size(0, 16);
            lblErrorId.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(316, 143);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(140, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(166, 233);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(290, 27);
            txtNombre.TabIndex = 8;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblHorario.Location = new Point(166, 430);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(70, 18);
            lblHorario.TabIndex = 7;
            lblHorario.Text = "Horario:";
            // 
            // cboHorarios
            // 
            cboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(166, 451);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(290, 28);
            cboHorarios.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(166, 278);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 5;
            label3.Text = "Especialista:";
            // 
            // cboEspe
            // 
            cboEspe.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspe.FormattingEnabled = true;
            cboEspe.Location = new Point(166, 299);
            cboEspe.Name = "cboEspe";
            cboEspe.Size = new Size(290, 28);
            cboEspe.TabIndex = 4;
            cboEspe.SelectionChangeCommitted += cboEspe_SelectionChangeCommitted;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(166, 352);
            label2.Name = "label2";
            label2.Size = new Size(115, 18);
            label2.TabIndex = 3;
            label2.Text = "SubCategoria:";
            // 
            // cboSubCat
            // 
            cboSubCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubCat.FormattingEnabled = true;
            cboSubCat.Location = new Point(166, 373);
            cboSubCat.Name = "cboSubCat";
            cboSubCat.Size = new Size(290, 28);
            cboSubCat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(166, 124);
            label1.Name = "label1";
            label1.Size = new Size(120, 18);
            label1.TabIndex = 1;
            label1.Text = "Nro de Cliente:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(166, 145);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(140, 27);
            txtIdCliente.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(316, 499);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 69);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(166, 500);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 68);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(166, 212);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(153, 18);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre de Cliente:";
            // 
            // btnModif
            // 
            btnModif.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModif.Location = new Point(18, 457);
            btnModif.Name = "btnModif";
            btnModif.Size = new Size(290, 68);
            btnModif.TabIndex = 10;
            btnModif.Text = "Modificar Turno";
            btnModif.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(18, 533);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(290, 68);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar Turno";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnVerTurnos
            // 
            btnVerTurnos.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerTurnos.Location = new Point(18, 307);
            btnVerTurnos.Name = "btnVerTurnos";
            btnVerTurnos.Size = new Size(138, 68);
            btnVerTurnos.TabIndex = 12;
            btnVerTurnos.Text = "Ver Turnos ";
            btnVerTurnos.UseVisualStyleBackColor = true;
            btnVerTurnos.Click += btnVerTurnos_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 244);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 15;
            label4.Text = "Especialista:";
            // 
            // cboEspeVerTurnos
            // 
            cboEspeVerTurnos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspeVerTurnos.FormattingEnabled = true;
            cboEspeVerTurnos.Location = new Point(18, 265);
            cboEspeVerTurnos.Name = "cboEspeVerTurnos";
            cboEspeVerTurnos.Size = new Size(290, 28);
            cboEspeVerTurnos.TabIndex = 14;
            cboEspeVerTurnos.SelectionChangeCommitted += cboEspeVerTurnos_SelectionChangeCommitted;
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(170, 307);
            button1.Name = "button1";
            button1.Size = new Size(138, 68);
            button1.TabIndex = 16;
            button1.Text = "Ver Turnos ";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlGrid
            // 
            pnlGrid.Controls.Add(dgvTurnos);
            pnlGrid.Location = new Point(986, 596);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(401, 286);
            pnlGrid.TabIndex = 18;
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
            dgvTurnos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTurnos.Location = new Point(39, 104);
            dgvTurnos.MultiSelect = false;
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.ReadOnly = true;
            dgvTurnos.RowHeadersVisible = false;
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.RowTemplate.Height = 29;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.Size = new Size(331, 71);
            dgvTurnos.TabIndex = 5;
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1399, 884);
            Controls.Add(pnlGrid);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(btnVerTurnos);
            Controls.Add(cboEspeVerTurnos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModif);
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
        private Button btnVerTurnos;
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
        private Button button1;
        private Panel pnlGrid;
        private DataGridView dgvTurnos;
    }
}