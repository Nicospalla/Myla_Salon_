namespace SoftwareGestion_Myla
{
    partial class frmGrillaClientes
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
            btnHistorial = new Button();
            lblFiltroRap = new Label();
            txtFiltroRapido = new TextBox();
            dgvGrillaClientes = new DataGridView();
            btnVenta = new Button();
            lblFiltroID = new Label();
            txtFiltroId = new TextBox();
            lblInfo = new Label();
            btnTurno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHistorial.Location = new Point(407, 503);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(148, 54);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "Ver Historial ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // lblFiltroRap
            // 
            lblFiltroRap.AutoSize = true;
            lblFiltroRap.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltroRap.Location = new Point(468, 70);
            lblFiltroRap.Name = "lblFiltroRap";
            lblFiltroRap.Size = new Size(63, 18);
            lblFiltroRap.TabIndex = 6;
            lblFiltroRap.Text = "Filtrar:";
            // 
            // txtFiltroRapido
            // 
            txtFiltroRapido.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltroRapido.Location = new Point(542, 66);
            txtFiltroRapido.MaximumSize = new Size(450, 27);
            txtFiltroRapido.Name = "txtFiltroRapido";
            txtFiltroRapido.Size = new Size(200, 27);
            txtFiltroRapido.TabIndex = 5;
            txtFiltroRapido.TextChanged += txtFiltroRapido_TextChanged;
            // 
            // dgvGrillaClientes
            // 
            dgvGrillaClientes.AllowUserToAddRows = false;
            dgvGrillaClientes.AllowUserToDeleteRows = false;
            dgvGrillaClientes.AllowUserToResizeColumns = false;
            dgvGrillaClientes.AllowUserToResizeRows = false;
            dgvGrillaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrillaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaClientes.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvGrillaClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvGrillaClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvGrillaClientes.Location = new Point(90, 99);
            dgvGrillaClientes.MultiSelect = false;
            dgvGrillaClientes.Name = "dgvGrillaClientes";
            dgvGrillaClientes.ReadOnly = true;
            dgvGrillaClientes.RowHeadersVisible = false;
            dgvGrillaClientes.RowHeadersWidth = 51;
            dgvGrillaClientes.RowTemplate.Height = 29;
            dgvGrillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaClientes.Size = new Size(701, 385);
            dgvGrillaClientes.TabIndex = 4;
            dgvGrillaClientes.ColumnHeaderMouseClick += dgvGrillaClientes_ColumnHeaderMouseClick;
            dgvGrillaClientes.MouseHover += dgvGrillaClientes_MouseHover;
            // 
            // btnVenta
            // 
            btnVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVenta.Location = new Point(244, 503);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(157, 54);
            btnVenta.TabIndex = 8;
            btnVenta.Text = "Nueva Venta";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // lblFiltroID
            // 
            lblFiltroID.AutoSize = true;
            lblFiltroID.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltroID.Location = new Point(91, 70);
            lblFiltroID.Name = "lblFiltroID";
            lblFiltroID.Size = new Size(63, 18);
            lblFiltroID.TabIndex = 10;
            lblFiltroID.Text = "Filtrar:";
            // 
            // txtFiltroId
            // 
            txtFiltroId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltroId.Location = new Point(165, 66);
            txtFiltroId.MaximumSize = new Size(250, 27);
            txtFiltroId.Name = "txtFiltroId";
            txtFiltroId.Size = new Size(200, 27);
            txtFiltroId.TabIndex = 9;
            txtFiltroId.TextChanged += txtFiltroId_TextChanged;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfo.ForeColor = Color.Red;
            lblInfo.Location = new Point(91, 38);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 16);
            lblInfo.TabIndex = 11;
            // 
            // btnTurno
            // 
            btnTurno.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTurno.Location = new Point(90, 503);
            btnTurno.Name = "btnTurno";
            btnTurno.Size = new Size(148, 54);
            btnTurno.TabIndex = 12;
            btnTurno.Text = "Agendar Turno";
            btnTurno.UseVisualStyleBackColor = true;
            btnTurno.Click += btnTurno_Click;
            // 
            // frmGrillaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(881, 588);
            Controls.Add(btnTurno);
            Controls.Add(lblInfo);
            Controls.Add(lblFiltroID);
            Controls.Add(txtFiltroId);
            Controls.Add(btnVenta);
            Controls.Add(btnHistorial);
            Controls.Add(lblFiltroRap);
            Controls.Add(txtFiltroRapido);
            Controls.Add(dgvGrillaClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGrillaClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmGrillaClientes";
            Load += frmGrillaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGrillaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHistorial;
        private Label lblFiltroRap;
        private TextBox txtFiltroRapido;
        private DataGridView dgvGrillaClientes;
        private Button btnVenta;
        private Label lblFiltroID;
        private TextBox txtFiltroId;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblInfo;
        private Button btnTurno;
    }
}