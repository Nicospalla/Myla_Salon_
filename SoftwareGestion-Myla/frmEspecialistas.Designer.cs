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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            dgvSubCat = new DataGridView();
            btnAgregaCat = new Button();
            btnAgregaSub = new Button();
            lblCat = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAtras = new Button();
            btnModifEsp = new Button();
            btnEliminarEsp = new Button();
            dgvNoCat = new DataGridView();
            dgvNoSubCat = new DataGridView();
            button1 = new Button();
            btnQuitaSub = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoSubCat).BeginInit();
            SuspendLayout();
            // 
            // cboEsp
            // 
            cboEsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEsp.FormattingEnabled = true;
            cboEsp.Location = new Point(157, 232);
            cboEsp.Name = "cboEsp";
            cboEsp.Size = new Size(232, 28);
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
            txtId.Size = new Size(232, 27);
            txtId.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(157, 403);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 27);
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
            txtEmail.Size = new Size(232, 27);
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
            dateCumple.Size = new Size(232, 27);
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
            dgvCat.Location = new Point(467, 213);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersWidth = 51;
            dgvCat.RowTemplate.Height = 29;
            dgvCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCat.Size = new Size(300, 149);
            dgvCat.TabIndex = 11;
            // 
            // dgvSubCat
            // 
            dgvSubCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubCat.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubCat.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubCat.Location = new Point(787, 213);
            dgvSubCat.Name = "dgvSubCat";
            dgvSubCat.RowHeadersWidth = 51;
            dgvSubCat.RowTemplate.Height = 29;
            dgvSubCat.Size = new Size(300, 149);
            dgvSubCat.TabIndex = 12;
            // 
            // btnAgregaCat
            // 
            btnAgregaCat.Location = new Point(467, 368);
            btnAgregaCat.Name = "btnAgregaCat";
            btnAgregaCat.Size = new Size(300, 29);
            btnAgregaCat.TabIndex = 13;
            btnAgregaCat.Text = "Agregar Categoría";
            btnAgregaCat.UseVisualStyleBackColor = true;
            // 
            // btnAgregaSub
            // 
            btnAgregaSub.Location = new Point(787, 368);
            btnAgregaSub.Name = "btnAgregaSub";
            btnAgregaSub.Size = new Size(300, 29);
            btnAgregaSub.TabIndex = 14;
            btnAgregaSub.Text = "Agregar Subcategoría";
            btnAgregaSub.UseVisualStyleBackColor = true;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCat.Location = new Point(467, 183);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(180, 18);
            lblCat.TabIndex = 17;
            lblCat.Text = "Categorías disponibles:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(787, 183);
            label5.Name = "label5";
            label5.Size = new Size(205, 18);
            label5.TabIndex = 18;
            label5.Text = "Subcategorías disponibles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(467, 440);
            label6.Name = "label6";
            label6.Size = new Size(161, 18);
            label6.TabIndex = 19;
            label6.Text = "Categorías incluidas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(787, 440);
            label7.Name = "label7";
            label7.Size = new Size(189, 18);
            label7.TabIndex = 20;
            label7.Text = "SubCategorías incluidas:";
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
            btnModifEsp.Location = new Point(277, 640);
            btnModifEsp.Name = "btnModifEsp";
            btnModifEsp.Size = new Size(204, 63);
            btnModifEsp.TabIndex = 22;
            btnModifEsp.Text = "Guardar Cambios";
            btnModifEsp.UseVisualStyleBackColor = true;
            // 
            // btnEliminarEsp
            // 
            btnEliminarEsp.Location = new Point(529, 640);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNoCat.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNoCat.Location = new Point(467, 466);
            dgvNoCat.Name = "dgvNoCat";
            dgvNoCat.RowHeadersWidth = 51;
            dgvNoCat.RowTemplate.Height = 29;
            dgvNoCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNoCat.Size = new Size(300, 149);
            dgvNoCat.TabIndex = 24;
            // 
            // dgvNoSubCat
            // 
            dgvNoSubCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNoSubCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNoSubCat.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvNoSubCat.DefaultCellStyle = dataGridViewCellStyle4;
            dgvNoSubCat.Location = new Point(787, 466);
            dgvNoSubCat.Name = "dgvNoSubCat";
            dgvNoSubCat.RowHeadersWidth = 51;
            dgvNoSubCat.RowTemplate.Height = 29;
            dgvNoSubCat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNoSubCat.Size = new Size(300, 149);
            dgvNoSubCat.TabIndex = 25;
            // 
            // button1
            // 
            button1.Location = new Point(467, 408);
            button1.Name = "button1";
            button1.Size = new Size(300, 29);
            button1.TabIndex = 26;
            button1.Text = "Quitar Categoría";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnQuitaSub
            // 
            btnQuitaSub.Location = new Point(787, 408);
            btnQuitaSub.Name = "btnQuitaSub";
            btnQuitaSub.Size = new Size(300, 29);
            btnQuitaSub.TabIndex = 27;
            btnQuitaSub.Text = "Quitar Subcategoría";
            btnQuitaSub.UseVisualStyleBackColor = true;
            // 
            // frmEspecialistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 750);
            Controls.Add(btnQuitaSub);
            Controls.Add(button1);
            Controls.Add(dgvNoSubCat);
            Controls.Add(dgvNoCat);
            Controls.Add(btnEliminarEsp);
            Controls.Add(btnModifEsp);
            Controls.Add(btnAtras);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblCat);
            Controls.Add(btnAgregaSub);
            Controls.Add(btnAgregaCat);
            Controls.Add(dgvSubCat);
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
            ((System.ComponentModel.ISupportInitialize)dgvSubCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoSubCat).EndInit();
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
        private DataGridView dgvSubCat;
        private Button btnAgregaCat;
        private Button btnAgregaSub;
        private Label lblCat;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAtras;
        private Button btnModifEsp;
        private Button btnEliminarEsp;
        private DataGridView dgvNoCat;
        private DataGridView dgvNoSubCat;
        private Button button1;
        private Button btnQuitaSub;
    }
}