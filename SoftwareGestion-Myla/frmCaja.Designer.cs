namespace SoftwareGestion_Myla
{
    partial class frmCaja
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
            monthCalendar1 = new MonthCalendar();
            txtRetiro = new TextBox();
            lblRetiro = new Label();
            label1 = new Label();
            txtPagoProv = new TextBox();
            label2 = new Label();
            txtIngreso = new TextBox();
            label3 = new Label();
            txtNombreProv = new TextBox();
            dataGridHisto = new DataGridView();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHisto).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(66, 92);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // txtRetiro
            // 
            txtRetiro.Location = new Point(372, 450);
            txtRetiro.Name = "txtRetiro";
            txtRetiro.Size = new Size(202, 27);
            txtRetiro.TabIndex = 1;
            // 
            // lblRetiro
            // 
            lblRetiro.AutoSize = true;
            lblRetiro.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblRetiro.Location = new Point(372, 427);
            lblRetiro.Name = "lblRetiro";
            lblRetiro.Size = new Size(146, 18);
            lblRetiro.TabIndex = 2;
            lblRetiro.Text = "Retiro de efectivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(372, 500);
            label1.Name = "label1";
            label1.Size = new Size(151, 18);
            label1.TabIndex = 4;
            label1.Text = "Pago proveedores:";
            // 
            // txtPagoProv
            // 
            txtPagoProv.Location = new Point(372, 523);
            txtPagoProv.Name = "txtPagoProv";
            txtPagoProv.Size = new Size(202, 27);
            txtPagoProv.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(372, 353);
            label2.Name = "label2";
            label2.Size = new Size(158, 18);
            label2.TabIndex = 6;
            label2.Text = "Ingreso de efectivo:";
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(372, 374);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(202, 27);
            txtIngreso.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(580, 500);
            label3.Name = "label3";
            label3.Size = new Size(157, 18);
            label3.TabIndex = 8;
            label3.Text = "Nombre proveedor:";
            // 
            // txtNombreProv
            // 
            txtNombreProv.Location = new Point(580, 523);
            txtNombreProv.Name = "txtNombreProv";
            txtNombreProv.Size = new Size(202, 27);
            txtNombreProv.TabIndex = 7;
            // 
            // dataGridHisto
            // 
            dataGridHisto.AllowUserToAddRows = false;
            dataGridHisto.AllowUserToDeleteRows = false;
            dataGridHisto.AllowUserToOrderColumns = true;
            dataGridHisto.AllowUserToResizeColumns = false;
            dataGridHisto.AllowUserToResizeRows = false;
            dataGridHisto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHisto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHisto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHisto.Location = new Point(372, 92);
            dataGridHisto.MultiSelect = false;
            dataGridHisto.Name = "dataGridHisto";
            dataGridHisto.ReadOnly = true;
            dataGridHisto.RowHeadersVisible = false;
            dataGridHisto.RowHeadersWidth = 51;
            dataGridHisto.RowTemplate.Height = 29;
            dataGridHisto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridHisto.Size = new Size(800, 228);
            dataGridHisto.TabIndex = 9;
            // 
            // btnAtras
            // 
            btnAtras.AutoSize = true;
            btnAtras.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 12);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(74, 68);
            btnAtras.TabIndex = 10;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmCaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 651);
            Controls.Add(btnAtras);
            Controls.Add(dataGridHisto);
            Controls.Add(label3);
            Controls.Add(txtNombreProv);
            Controls.Add(label2);
            Controls.Add(txtIngreso);
            Controls.Add(label1);
            Controls.Add(txtPagoProv);
            Controls.Add(lblRetiro);
            Controls.Add(txtRetiro);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCaja";
            Text = "frmCaja";
            ((System.ComponentModel.ISupportInitialize)dataGridHisto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox txtRetiro;
        private Label lblRetiro;
        private Label label1;
        private TextBox txtPagoProv;
        private Label label2;
        private TextBox txtIngreso;
        private Label label3;
        private TextBox txtNombreProv;
        private DataGridView dataGridHisto;
        private Button btnAtras;
    }
}