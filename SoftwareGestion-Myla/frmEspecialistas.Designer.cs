namespace SoftwareGestion_Myla
{
    partial class frmEspecialistas
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
            cboEsp = new ComboBox();
            lblTitulo = new Label();
            lblEsp = new Label();
            label1 = new Label();
            txtId = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            lblCumple = new Label();
            dateCumple = new DateTimePicker();
            dgvCat = new DataGridView();
            btnAgregaCat = new Button();
            lblCat = new Label();
            label6 = new Label();
            btnAtras = new Button();
            btnModifEsp = new Button();
            btnEliminarEsp = new Button();
            dgvNoCat = new DataGridView();
            btnQuitarCat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoCat).BeginInit();
            SuspendLayout();
            // 
            // cboEsp
            // 
            cboEsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEsp.FormattingEnabled = true;
            cboEsp.Location = new Point(157, 232);
            cboEsp.Name = "cboEsp";
            cboEsp.Size = new Size(280, 28);
            cboEsp.TabIndex = 0;
            cboEsp.SelectedIndexChanged += cboEsp_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(157, 133);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar Especialista:";
            // 
            // lblEsp
            // 
            lblEsp.AutoSize = true;
            lblEsp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsp.Location = new Point(157, 194);
            lblEsp.Name = "lblEsp";
            lblEsp.Size = new Size(205, 18);
            lblEsp.TabIndex = 2;
            lblEsp.Text = "Seleccione un especialista:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(157, 280);
            label1.Name = "label1";
            label1.Size = new Size(187, 18);
            label1.TabIndex = 3;
            label1.Text = "Número de Especialista:";
            // 
            // txtId
            // 
            txtId.Location = new Point(157, 318);
            txtId.Name = "txtId";
            txtId.Size = new Size(280, 27);
            txtId.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(157, 403);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 27);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 365);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(157, 488);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(157, 450);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // lblCumple
            // 
            lblCumple.AutoSize = true;
            lblCumple.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumple.Location = new Point(157, 535);
            lblCumple.Name = "lblCumple";
            lblCumple.Size = new Size(168, 18);
            lblCumple.TabIndex = 9;
            lblCumple.Text = "Fecha de nacimiento:";
            // 
            // dateCumple
            // 
            dateCumple.Location = new Point(157, 573);
            dateCumple.Name = "dateCumple";
            dateCumple.Size = new Size(280, 27);
            dateCumple.TabIndex = 10;
            // 
            // dgvCat
            // 
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
            dgvCat.Location = new Point(476, 213);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersWidth = 51;
            dgvCat.RowTemplate.Height = 29;
            dgvCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCat.Size = new Size(238, 387);
            dgvCat.TabIndex = 11;
            // 
            // btnAgregaCat
            // 
            btnAgregaCat.Location = new Point(720, 289);
            btnAgregaCat.Name = "btnAgregaCat";
            btnAgregaCat.Size = new Size(85, 85);
            btnAgregaCat.TabIndex = 13;
            btnAgregaCat.Text = "Agregar Categoría  <==";
            btnAgregaCat.UseVisualStyleBackColor = true;
            btnAgregaCat.Click += btnAgregaCat_Click;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCat.Location = new Point(476, 183);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(163, 18);
            lblCat.TabIndex = 17;
            lblCat.Text = "Categorías Incluidas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(811, 183);
            label6.Name = "label6";
            label6.Size = new Size(189, 18);
            label6.TabIndex = 19;
            label6.Text = "Categorías NO incluidas:";
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(90, 90);
            btnAtras.TabIndex = 21;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnModifEsp
            // 
            btnModifEsp.Location = new Point(328, 638);
            btnModifEsp.Name = "btnModifEsp";
            btnModifEsp.Size = new Size(204, 63);
            btnModifEsp.TabIndex = 22;
            btnModifEsp.Text = "Guardar Cambios";
            btnModifEsp.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEsp
            // 
            btnEliminarEsp.Location = new Point(580, 638);
            btnEliminarEsp.Name = "btnEliminarEsp";
            btnEliminarEsp.Size = new Size(204, 63);
            btnEliminarEsp.TabIndex = 23;
            btnEliminarEsp.Text = "Eliminar Especialista";
            btnEliminarEsp.UseVisualStyleBackColor = true;
            // 
            // dgvNoCat
            // 
            dgvNoCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNoCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoCat.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNoCat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNoCat.Location = new Point(811, 213);
            dgvNoCat.Name = "dgvNoCat";
            dgvNoCat.RowHeadersWidth = 51;
            dgvNoCat.RowTemplate.Height = 29;
            dgvNoCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNoCat.Size = new Size(238, 387);
            dgvNoCat.TabIndex = 24;
            // 
            // btnQuitarCat
            // 
            btnQuitarCat.Location = new Point(720, 430);
            btnQuitarCat.Name = "btnQuitarCat";
            btnQuitarCat.Size = new Size(85, 85);
            btnQuitarCat.TabIndex = 26;
            btnQuitarCat.Text = "Quitar Categoría  ==>";
            btnQuitarCat.UseVisualStyleBackColor = true;
            btnQuitarCat.Click += btnQuitarCat_Click;
            // 
            // frmEspecialistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 750);
            Controls.Add(btnQuitarCat);
            Controls.Add(dgvNoCat);
            Controls.Add(btnEliminarEsp);
            Controls.Add(btnModifEsp);
            Controls.Add(btnAtras);
            Controls.Add(label6);
            Controls.Add(lblCat);
            Controls.Add(btnAgregaCat);
            Controls.Add(dgvCat);
            Controls.Add(dateCumple);
            Controls.Add(lblCumple);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(lblEsp);
            Controls.Add(lblTitulo);
            Controls.Add(cboEsp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEspecialistas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEspecialistas";
            Load += frmEspecialistas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEsp;
        private Label lblTitulo;
        private Label lblEsp;
        private Label label1;
        private TextBox txtId;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label lblCumple;
        private DateTimePicker dateCumple;
        private DataGridView dgvCat;
        private Button btnAgregaCat;
        private Label lblCat;
        private Label label6;
        private Button btnAtras;
        private Button btnModifEsp;
        private Button btnEliminarEsp;
        private DataGridView dgvNoCat;
        private Button btnQuitarCat;
    }
}