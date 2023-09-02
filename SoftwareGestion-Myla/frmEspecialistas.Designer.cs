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
            txtPorcentaje = new TextBox();
            txtSueldo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblErrorApellido = new Label();
            lblErrorTel = new Label();
            lblErrorEmail = new Label();
            lblErrorSueldo = new Label();
            lblErrorPorcen = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNoCat).BeginInit();
            SuspendLayout();
            // 
            // cboEsp
            // 
            cboEsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEsp.FormattingEnabled = true;
            cboEsp.Location = new Point(142, 189);
            cboEsp.Name = "cboEsp";
            cboEsp.Size = new Size(280, 28);
            cboEsp.TabIndex = 0;
            cboEsp.SelectedIndexChanged += cboEsp_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(142, 95);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar Especialista:";
            // 
            // lblEsp
            // 
            lblEsp.AutoSize = true;
            lblEsp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsp.Location = new Point(142, 168);
            lblEsp.Name = "lblEsp";
            lblEsp.Size = new Size(205, 18);
            lblEsp.TabIndex = 2;
            lblEsp.Text = "Seleccione un especialista:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(142, 244);
            label1.Name = "label1";
            label1.Size = new Size(187, 18);
            label1.TabIndex = 3;
            label1.Text = "Número de Especialista:";
            // 
            // txtId
            // 
            txtId.Location = new Point(142, 265);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(280, 27);
            txtId.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(142, 340);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(280, 27);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 319);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // lblCumple
            // 
            lblCumple.AutoSize = true;
            lblCumple.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumple.Location = new Point(142, 544);
            lblCumple.Name = "lblCumple";
            lblCumple.Size = new Size(168, 18);
            lblCumple.TabIndex = 9;
            lblCumple.Text = "Fecha de nacimiento:";
            // 
            // dateCumple
            // 
            dateCumple.Location = new Point(142, 565);
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
            btnAgregaCat.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregaCat.ForeColor = SystemColors.ActiveCaptionText;
            btnAgregaCat.Location = new Point(720, 280);
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
            lblCat.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCat.Location = new Point(476, 183);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(181, 18);
            lblCat.TabIndex = 17;
            lblCat.Text = "Categorías Incluidas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(811, 183);
            label6.Name = "label6";
            label6.Size = new Size(207, 18);
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
            btnModifEsp.Click += btnModifEsp_Click;
            // 
            // btnEliminarEsp
            // 
            btnEliminarEsp.Location = new Point(580, 638);
            btnEliminarEsp.Name = "btnEliminarEsp";
            btnEliminarEsp.Size = new Size(204, 63);
            btnEliminarEsp.TabIndex = 23;
            btnEliminarEsp.Text = "Eliminar Especialista";
            btnEliminarEsp.UseVisualStyleBackColor = true;
            btnEliminarEsp.Click += btnEliminarEsp_Click;
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
            btnQuitarCat.Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuitarCat.Location = new Point(720, 430);
            btnQuitarCat.Name = "btnQuitarCat";
            btnQuitarCat.Size = new Size(85, 85);
            btnQuitarCat.TabIndex = 26;
            btnQuitarCat.Text = "Quitar Categoría  ==>";
            btnQuitarCat.UseVisualStyleBackColor = true;
            btnQuitarCat.Click += btnQuitarCat_Click;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.BackColor = SystemColors.Window;
            txtPorcentaje.Location = new Point(1094, 386);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(230, 27);
            txtPorcentaje.TabIndex = 27;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(1094, 301);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(230, 27);
            txtSueldo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(1094, 213);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 29;
            label4.Text = "Finanzas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1094, 263);
            label5.Name = "label5";
            label5.Size = new Size(103, 18);
            label5.TabIndex = 30;
            label5.Text = "Sueldo FIJO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1094, 348);
            label7.Name = "label7";
            label7.Size = new Size(95, 18);
            label7.TabIndex = 31;
            label7.Text = "Porcentaje:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Window;
            label8.Location = new Point(1291, 389);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 32;
            label8.Text = "%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Window;
            label9.Location = new Point(1291, 304);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 33;
            label9.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(142, 469);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(142, 490);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(280, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(142, 415);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 27);
            txtTelefono.TabIndex = 35;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(142, 395);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(77, 18);
            lblTelefono.TabIndex = 34;
            lblTelefono.Text = "Telefono:";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(142, 370);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(0, 17);
            lblErrorApellido.TabIndex = 36;
            // 
            // lblErrorTel
            // 
            lblErrorTel.AutoSize = true;
            lblErrorTel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorTel.ForeColor = Color.Red;
            lblErrorTel.Location = new Point(142, 445);
            lblErrorTel.Name = "lblErrorTel";
            lblErrorTel.Size = new Size(0, 17);
            lblErrorTel.TabIndex = 37;
            // 
            // lblErrorEmail
            // 
            lblErrorEmail.AutoSize = true;
            lblErrorEmail.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorEmail.ForeColor = Color.Red;
            lblErrorEmail.Location = new Point(142, 520);
            lblErrorEmail.Name = "lblErrorEmail";
            lblErrorEmail.Size = new Size(0, 17);
            lblErrorEmail.TabIndex = 38;
            // 
            // lblErrorSueldo
            // 
            lblErrorSueldo.AutoSize = true;
            lblErrorSueldo.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorSueldo.ForeColor = Color.Red;
            lblErrorSueldo.Location = new Point(1094, 331);
            lblErrorSueldo.Name = "lblErrorSueldo";
            lblErrorSueldo.Size = new Size(0, 17);
            lblErrorSueldo.TabIndex = 39;
            // 
            // lblErrorPorcen
            // 
            lblErrorPorcen.AutoSize = true;
            lblErrorPorcen.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorPorcen.ForeColor = Color.Red;
            lblErrorPorcen.Location = new Point(1094, 420);
            lblErrorPorcen.Name = "lblErrorPorcen";
            lblErrorPorcen.Size = new Size(0, 17);
            lblErrorPorcen.TabIndex = 40;
            // 
            // frmEspecialistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 750);
            Controls.Add(lblErrorPorcen);
            Controls.Add(lblErrorSueldo);
            Controls.Add(lblErrorEmail);
            Controls.Add(lblErrorTel);
            Controls.Add(lblErrorApellido);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSueldo);
            Controls.Add(txtPorcentaje);
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
        private TextBox txtPorcentaje;
        private TextBox txtSueldo;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblErrorApellido;
        private Label lblErrorTel;
        private Label lblErrorEmail;
        private Label lblErrorSueldo;
        private Label lblErrorPorcen;
    }
}