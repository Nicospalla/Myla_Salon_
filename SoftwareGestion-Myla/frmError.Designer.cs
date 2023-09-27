namespace SoftwareGestion_Myla
{
    partial class frmError
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
            linkLabel = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel.Location = new Point(56, 178);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(459, 20);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = "https://www.microsoft.com/es-es/sql-server/sql-server-downloads";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 74);
            label1.Name = "label1";
            label1.Size = new Size(532, 20);
            label1.TabIndex = 1;
            label1.Text = "Debe instalar SQL Server 2019 antes de utilizar la aplicación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(161, 114);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 2;
            label2.Text = "Puede hacerlo desde aquí:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(202, 242);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 53);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmError
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 340);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel);
            Name = "frmError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Requisito previo";
            FormClosed += frmError_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
    }
}