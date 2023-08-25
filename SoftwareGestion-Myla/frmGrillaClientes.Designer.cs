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
            btnHistorial = new Button();
            lblFiltroRap = new Label();
            txtFiltroRapido = new TextBox();
            dgvGrillaClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvGrillaClientes).BeginInit();
            SuspendLayout();
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnHistorial.Location = new Point(90, 500);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(148, 29);
            btnHistorial.TabIndex = 7;
            btnHistorial.Text = "Ver Historial ";
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // lblFiltroRap
            // 
            lblFiltroRap.AutoSize = true;
            lblFiltroRap.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiltroRap.Location = new Point(100, 64);
            lblFiltroRap.Name = "lblFiltroRap";
            lblFiltroRap.Size = new Size(63, 18);
            lblFiltroRap.TabIndex = 6;
            lblFiltroRap.Text = "Filtrar:";
            // 
            // txtFiltroRapido
            // 
            txtFiltroRapido.Location = new Point(174, 60);
            txtFiltroRapido.Name = "txtFiltroRapido";
            txtFiltroRapido.Size = new Size(440, 27);
            txtFiltroRapido.TabIndex = 5;
            txtFiltroRapido.TextChanged += txtFiltroRapido_TextChanged;
            // 
            // dgvGrillaClientes
            // 
            dgvGrillaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGrillaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrillaClientes.Location = new Point(90, 99);
            dgvGrillaClientes.MultiSelect = false;
            dgvGrillaClientes.Name = "dgvGrillaClientes";
            dgvGrillaClientes.ReadOnly = true;
            dgvGrillaClientes.RowHeadersWidth = 51;
            dgvGrillaClientes.RowTemplate.Height = 29;
            dgvGrillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrillaClientes.Size = new Size(701, 385);
            dgvGrillaClientes.TabIndex = 4;
            // 
            // frmGrillaClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(881, 588);
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
    }
}