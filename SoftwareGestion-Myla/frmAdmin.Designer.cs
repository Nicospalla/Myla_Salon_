namespace SoftwareGestion_Myla
{
    partial class frmAdmin
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
            pnlBackUp = new Panel();
            lblEnviando = new Label();
            btnEmail = new Button();
            label1 = new Label();
            txtMail = new TextBox();
            panel1 = new Panel();
            btnRestaurar = new Button();
            btnOpenFile = new Button();
            label2 = new Label();
            txtFile = new TextBox();
            OpenFile = new OpenFileDialog();
            pnlBackUp.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackUp
            // 
            pnlBackUp.BorderStyle = BorderStyle.FixedSingle;
            pnlBackUp.Controls.Add(lblEnviando);
            pnlBackUp.Controls.Add(btnEmail);
            pnlBackUp.Controls.Add(label1);
            pnlBackUp.Controls.Add(txtMail);
            pnlBackUp.Location = new Point(107, 142);
            pnlBackUp.Name = "pnlBackUp";
            pnlBackUp.Size = new Size(312, 147);
            pnlBackUp.TabIndex = 0;
            // 
            // lblEnviando
            // 
            lblEnviando.AutoSize = true;
            lblEnviando.Font = new Font("Verdana", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnviando.ForeColor = Color.Red;
            lblEnviando.Location = new Point(27, 125);
            lblEnviando.Name = "lblEnviando";
            lblEnviando.Size = new Size(0, 16);
            lblEnviando.TabIndex = 3;
            // 
            // btnEmail
            // 
            btnEmail.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmail.Location = new Point(13, 93);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(278, 29);
            btnEmail.TabIndex = 2;
            btnEmail.Text = "Registar";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(153, 18);
            label1.TabIndex = 1;
            label1.Text = "Email para BackUp:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(12, 42);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(278, 27);
            txtMail.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnOpenFile);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFile);
            panel1.Location = new Point(472, 142);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 147);
            panel1.TabIndex = 1;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestaurar.Location = new Point(14, 93);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(278, 29);
            btnRestaurar.TabIndex = 5;
            btnRestaurar.Text = "Restaurar Base de Datos";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(324, 43);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(65, 27);
            btnOpenFile.TabIndex = 2;
            btnOpenFile.Text = "Buscar";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 17);
            label2.Name = "label2";
            label2.Size = new Size(134, 18);
            label2.TabIndex = 6;
            label2.Text = "Restaurar BBDD:";
            // 
            // txtFile
            // 
            txtFile.Location = new Point(14, 43);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(375, 27);
            txtFile.TabIndex = 2;
            // 
            // OpenFile
            // 
            OpenFile.FileName = "openFileDialog1";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1208, 677);
            Controls.Add(panel1);
            Controls.Add(pnlBackUp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAdmin";
            pnlBackUp.ResumeLayout(false);
            pnlBackUp.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBackUp;
        private Button btnEmail;
        private Label label1;
        private TextBox txtMail;
        private Panel panel1;
        private Label label2;
        private Button btnOpenFile;
        private OpenFileDialog OpenFile;
        private TextBox txtFile;
        private Button btnRestaurar;
        private Label lblEnviando;
    }
}