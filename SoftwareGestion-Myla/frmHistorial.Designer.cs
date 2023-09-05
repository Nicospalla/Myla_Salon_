namespace SoftwareGestion_Myla
{
    partial class frmHistorial
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
            dgvHistorial = new DataGridView();
            btnAtras = new Button();
            btnEditaVta = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.AllowUserToOrderColumns = true;
            dgvHistorial.AllowUserToResizeColumns = false;
            dgvHistorial.AllowUserToResizeRows = false;
            dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(80, 42);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 29;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(701, 385);
            dgvHistorial.TabIndex = 5;
            // 
            // btnAtras
            // 
            btnAtras.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAtras.Location = new Point(80, 444);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(144, 42);
            btnAtras.TabIndex = 6;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnEditaVta
            // 
            btnEditaVta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditaVta.Location = new Point(230, 444);
            btnEditaVta.Name = "btnEditaVta";
            btnEditaVta.Size = new Size(144, 42);
            btnEditaVta.TabIndex = 7;
            btnEditaVta.Text = "Editar Venta";
            btnEditaVta.UseVisualStyleBackColor = true;
            btnEditaVta.Click += btnEditaVta_Click;
            // 
            // frmHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(848, 521);
            Controls.Add(btnEditaVta);
            Controls.Add(btnAtras);
            Controls.Add(dgvHistorial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistorial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmHistorial";
            Load += frmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorial;
        private Button btnAtras;
        private Button btnEditaVta;
    }
}