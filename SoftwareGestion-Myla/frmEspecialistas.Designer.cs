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
            cboEsp = new ComboBox();
            lblTitulo = new Label();
            lblEsp = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            lblCumple = new Label();
            dateCumple = new DateTimePicker();
            dgvCat = new DataGridView();
            dgvSubCat = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            dgvCatResul = new DataGridView();
            dgvSubCatResul = new DataGridView();
            lblCat = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCatResul).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCatResul).BeginInit();
            SuspendLayout();
            // 
            // cboEsp
            // 
            cboEsp.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEsp.FormattingEnabled = true;
            cboEsp.Location = new Point(113, 191);
            cboEsp.Name = "cboEsp";
            cboEsp.Size = new Size(232, 28);
            cboEsp.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(113, 92);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Editar Especialista:";
            // 
            // lblEsp
            // 
            lblEsp.AutoSize = true;
            lblEsp.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEsp.Location = new Point(113, 153);
            lblEsp.Name = "lblEsp";
            lblEsp.Size = new Size(197, 18);
            lblEsp.TabIndex = 2;
            lblEsp.Text = "Seleccione un especialita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 239);
            label1.Name = "label1";
            label1.Size = new Size(75, 18);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 277);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 362);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 27);
            txtApellido.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(113, 324);
            label2.Name = "label2";
            label2.Size = new Size(71, 18);
            label2.TabIndex = 5;
            label2.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(113, 447);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 27);
            txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(113, 409);
            label3.Name = "label3";
            label3.Size = new Size(54, 18);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // lblCumple
            // 
            lblCumple.AutoSize = true;
            lblCumple.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCumple.Location = new Point(113, 494);
            lblCumple.Name = "lblCumple";
            lblCumple.Size = new Size(168, 18);
            lblCumple.TabIndex = 9;
            lblCumple.Text = "Fecha de nacimiento:";
            // 
            // dateCumple
            // 
            dateCumple.Location = new Point(113, 532);
            dateCumple.Name = "dateCumple";
            dateCumple.Size = new Size(232, 27);
            dateCumple.TabIndex = 10;
            // 
            // dgvCat
            // 
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat.Location = new Point(423, 172);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersWidth = 51;
            dgvCat.RowTemplate.Height = 29;
            dgvCat.Size = new Size(300, 149);
            dgvCat.TabIndex = 11;
            // 
            // dgvSubCat
            // 
            dgvSubCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubCat.Location = new Point(743, 172);
            dgvSubCat.Name = "dgvSubCat";
            dgvSubCat.RowHeadersWidth = 51;
            dgvSubCat.RowTemplate.Height = 29;
            dgvSubCat.Size = new Size(300, 149);
            dgvSubCat.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(423, 352);
            button1.Name = "button1";
            button1.Size = new Size(300, 29);
            button1.TabIndex = 13;
            button1.Text = "Agregar Categoria";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(743, 352);
            button2.Name = "button2";
            button2.Size = new Size(300, 29);
            button2.TabIndex = 14;
            button2.Text = "Agregar Subcategoria";
            button2.UseVisualStyleBackColor = true;
            // 
            // dgvCatResul
            // 
            dgvCatResul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatResul.Location = new Point(423, 409);
            dgvCatResul.Name = "dgvCatResul";
            dgvCatResul.RowHeadersWidth = 51;
            dgvCatResul.RowTemplate.Height = 29;
            dgvCatResul.Size = new Size(300, 149);
            dgvCatResul.TabIndex = 15;
            // 
            // dgvSubCatResul
            // 
            dgvSubCatResul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubCatResul.Location = new Point(743, 409);
            dgvSubCatResul.Name = "dgvSubCatResul";
            dgvSubCatResul.RowHeadersWidth = 51;
            dgvSubCatResul.RowTemplate.Height = 29;
            dgvSubCatResul.Size = new Size(300, 149);
            dgvSubCatResul.TabIndex = 16;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCat.Location = new Point(423, 142);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(180, 18);
            lblCat.TabIndex = 17;
            lblCat.Text = "Categorias disponibles:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(743, 142);
            label5.Name = "label5";
            label5.Size = new Size(205, 18);
            label5.TabIndex = 18;
            label5.Text = "Subcategorias disponibles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(423, 384);
            label6.Name = "label6";
            label6.Size = new Size(161, 18);
            label6.TabIndex = 19;
            label6.Text = "Categorias incluidas:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(743, 384);
            label7.Name = "label7";
            label7.Size = new Size(189, 18);
            label7.TabIndex = 20;
            label7.Text = "SubCategorias incluidas:";
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
            // 
            // frmEspecialistas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 604);
            Controls.Add(btnAtras);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblCat);
            Controls.Add(dgvSubCatResul);
            Controls.Add(dgvCatResul);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvSubCat);
            Controls.Add(dgvCat);
            Controls.Add(dateCumple);
            Controls.Add(lblCumple);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
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
            ((System.ComponentModel.ISupportInitialize)dgvCatResul).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubCatResul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEsp;
        private Label lblTitulo;
        private Label lblEsp;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private Label lblCumple;
        private DateTimePicker dateCumple;
        private DataGridView dgvCat;
        private DataGridView dgvSubCat;
        private Button button1;
        private Button button2;
        private DataGridView dgvCatResul;
        private DataGridView dgvSubCatResul;
        private Label lblCat;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAtras;
    }
}