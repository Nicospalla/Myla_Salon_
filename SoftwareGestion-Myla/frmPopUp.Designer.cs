namespace SoftwareGestion_Myla
{
    partial class frmPopUp
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
            lblEft = new Label();
            txtEft = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblEft
            // 
            lblEft.AutoSize = true;
            lblEft.Location = new Point(53, 83);
            lblEft.Name = "lblEft";
            lblEft.Size = new Size(116, 20);
            lblEft.TabIndex = 9;
            lblEft.Text = "Efectivo en caja:";
            // 
            // txtEft
            // 
            txtEft.Location = new Point(53, 116);
            txtEft.Name = "txtEft";
            txtEft.Size = new Size(334, 27);
            txtEft.TabIndex = 6;
            txtEft.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 198);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(189, 49);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(247, 198);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(189, 49);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 331);
            Controls.Add(lblEft);
            Controls.Add(txtEft);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopUp";
            Text = "frmPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEft;
        private TextBox txtEft;
        private Button btnGuardar;
        private Button btnSalir;
    }
}