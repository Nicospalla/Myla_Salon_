namespace SoftwareGestion_Myla
{
    partial class frmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCat = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnNuevaCat = new Button();
            txtCategoria = new TextBox();
            btnElimiCat = new Button();
            btnAgregarSub = new Button();
            btnEliminaSub = new Button();
            lblTiempo = new Label();
            cboHorarios = new ComboBox();
            txtSubCat = new TextBox();
            dgvSubCat = new DataGridView();
            lblSubCat = new Label();
            lblErrorDuracion = new Label();
            pnlSubCat = new Panel();
            lblSubCatTitle = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCat).BeginInit();
            pnlSubCat.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCat
            // 
            dgvCat.AllowUserToAddRows = false;
            dgvCat.AllowUserToDeleteRows = false;
            dgvCat.AllowUserToResizeColumns = false;
            dgvCat.AllowUserToResizeRows = false;
            dgvCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCat.DefaultCellStyle = dataGridViewCellStyle1;
            dgvCat.Location = new Point(209, 99);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersVisible = false;
            dgvCat.RowHeadersWidth = 51;
            dgvCat.RowTemplate.Height = 29;
            dgvCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCat.Size = new Size(238, 387);
            dgvCat.TabIndex = 12;
            dgvCat.SelectionChanged += dgvCat_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(209, 67);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 14;
            label1.Text = "Categorías:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(557, 67);
            label2.Name = "label2";
            label2.Size = new Size(133, 18);
            label2.TabIndex = 15;
            label2.Text = "SubCategorías:";
            // 
            // btnNuevaCat
            // 
            btnNuevaCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaCat.Location = new Point(209, 543);
            btnNuevaCat.Name = "btnNuevaCat";
            btnNuevaCat.Size = new Size(238, 29);
            btnNuevaCat.TabIndex = 16;
            btnNuevaCat.Text = "Agregar";
            btnNuevaCat.UseVisualStyleBackColor = true;
            btnNuevaCat.Click += btnNuevaCat_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(209, 501);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(238, 27);
            txtCategoria.TabIndex = 17;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnElimiCat
            // 
            btnElimiCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnElimiCat.Location = new Point(209, 578);
            btnElimiCat.Name = "btnElimiCat";
            btnElimiCat.Size = new Size(238, 29);
            btnElimiCat.TabIndex = 18;
            btnElimiCat.Text = "Eliminar";
            btnElimiCat.UseVisualStyleBackColor = true;
            btnElimiCat.Click += btnElimiCat_Click;
            // 
            // btnAgregarSub
            // 
            btnAgregarSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarSub.Location = new Point(819, 99);
            btnAgregarSub.Name = "btnAgregarSub";
            btnAgregarSub.Size = new Size(217, 67);
            btnAgregarSub.TabIndex = 19;
            btnAgregarSub.Text = "Agregar nueva SubCategoría";
            btnAgregarSub.UseVisualStyleBackColor = true;
            btnAgregarSub.Click += btnAgregarSub_Click;
            // 
            // btnEliminaSub
            // 
            btnEliminaSub.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminaSub.Location = new Point(557, 499);
            btnEliminaSub.Name = "btnEliminaSub";
            btnEliminaSub.Size = new Size(238, 29);
            btnEliminaSub.TabIndex = 20;
            btnEliminaSub.Text = "Eliminar";
            btnEliminaSub.UseVisualStyleBackColor = true;
            btnEliminaSub.Click += btnEliminaSub_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Verdana", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTiempo.Location = new Point(13, 131);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(144, 16);
            lblTiempo.TabIndex = 21;
            lblTiempo.Text = "Tiempo de trabajo:";
            // 
            // cboHorarios
            // 
            cboHorarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHorarios.FormattingEnabled = true;
            cboHorarios.Location = new Point(13, 160);
            cboHorarios.Name = "cboHorarios";
            cboHorarios.Size = new Size(204, 28);
            cboHorarios.TabIndex = 22;
            // 
            // txtSubCat
            // 
            txtSubCat.Location = new Point(13, 68);
            txtSubCat.Name = "txtSubCat";
            txtSubCat.Size = new Size(204, 27);
            txtSubCat.TabIndex = 24;
            // 
            // dgvSubCat
            // 
            dgvSubCat.AllowUserToAddRows = false;
            dgvSubCat.AllowUserToDeleteRows = false;
            dgvSubCat.AllowUserToResizeColumns = false;
            dgvSubCat.AllowUserToResizeRows = false;
            dgvSubCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubCat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubCat.Location = new Point(557, 99);
            dgvSubCat.Name = "dgvSubCat";
            dgvSubCat.RowHeadersVisible = false;
            dgvSubCat.RowHeadersWidth = 51;
            dgvSubCat.RowTemplate.Height = 29;
            dgvSubCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubCat.Size = new Size(238, 387);
            dgvSubCat.TabIndex = 27;
            dgvSubCat.CellContentClick += dgvSubCat_CellContentClick;
            dgvSubCat.SelectionChanged += dgvSubCat_SelectionChanged;
            // 
            // lblSubCat
            // 
            lblSubCat.AutoSize = true;
            lblSubCat.Font = new Font("Verdana", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSubCat.Location = new Point(13, 40);
            lblSubCat.Name = "lblSubCat";
            lblSubCat.Size = new Size(109, 16);
            lblSubCat.TabIndex = 28;
            lblSubCat.Text = "SubCategoría:";
            // 
            // lblErrorDuracion
            // 
            lblErrorDuracion.AutoSize = true;
            lblErrorDuracion.Font = new Font("Verdana", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorDuracion.ForeColor = Color.Red;
            lblErrorDuracion.Location = new Point(13, 196);
            lblErrorDuracion.Name = "lblErrorDuracion";
            lblErrorDuracion.Size = new Size(0, 16);
            lblErrorDuracion.TabIndex = 29;
            // 
            // pnlSubCat
            // 
            pnlSubCat.Controls.Add(lblSubCatTitle);
            pnlSubCat.Controls.Add(btnCancelar);
            pnlSubCat.Controls.Add(btnGuardar);
            pnlSubCat.Controls.Add(lblErrorDuracion);
            pnlSubCat.Controls.Add(lblSubCat);
            pnlSubCat.Controls.Add(txtSubCat);
            pnlSubCat.Controls.Add(cboHorarios);
            pnlSubCat.Controls.Add(lblTiempo);
            pnlSubCat.Location = new Point(819, 172);
            pnlSubCat.Name = "pnlSubCat";
            pnlSubCat.Size = new Size(357, 314);
            pnlSubCat.TabIndex = 30;
            // 
            // lblSubCatTitle
            // 
            lblSubCatTitle.AutoSize = true;
            lblSubCatTitle.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubCatTitle.Location = new Point(13, 10);
            lblSubCatTitle.Name = "lblSubCatTitle";
            lblSubCatTitle.Size = new Size(87, 22);
            lblSubCatTitle.TabIndex = 31;
            lblSubCatTitle.Text = "EDITAR";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(13, 259);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(204, 29);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(13, 224);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(204, 29);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 696);
            Controls.Add(pnlSubCat);
            Controls.Add(dgvSubCat);
            Controls.Add(btnEliminaSub);
            Controls.Add(btnAgregarSub);
            Controls.Add(btnElimiCat);
            Controls.Add(txtCategoria);
            Controls.Add(btnNuevaCat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategorias";
            Text = "frmCategorias";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCat).EndInit();
            pnlSubCat.ResumeLayout(false);
            pnlSubCat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCat;
        private Label label1;
        private Label label2;
        private Button btnNuevaCat;
        private TextBox txtCategoria;
        private Button btnElimiCat;
        private Button btnAgregarSub;
        private Button btnEliminaSub;
        private Label lblTiempo;
        private ComboBox cboHorarios;
        private TextBox txtSubCat;
        private DataGridView dgvSubCat;
        private Label lblSubCat;
        private Label lblErrorDuracion;
        private Panel pnlSubCat;
        private Button btnGuardar;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Button btnCancelar;
        private Label lblSubCatTitle;
    }
}