using Accesorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGestion_Myla
{
    public partial class frmAdmin : Form
    {
        frmPrincipal principal;
        Helpers help = new();
        public frmAdmin(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            file.Title = "Seleccionar BackUp";
            file.Filter = "Archivos de copia de seguridad (*.bak)|*.bak";

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = string.Empty;
                string filePath = file.FileName;
                txtFile.Text = filePath;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea restaurar la BBDD?\nEsta acción es irreversible!", "Restaurar BBDD", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show("Lo siento, pero debemos repetir el consetimiento.\nEstá seguro de restaurar la BBDD?", "Restaurar BBDD", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        help.restaurarBBDD();
                        principal.nuevoTurno();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            if (!string.IsNullOrEmpty(mail))
            {
                lblEnviando.Text = "Enviando Back Up, espere por favor.";
                string dirActual = AppDomain.CurrentDomain.BaseDirectory;
                string rutaMail = Path.Combine(dirActual, "BBDD\\mailBackUp.txt");
                btnEmail.Enabled = false;

                try
                {
                    StreamWriter streamWriter = new StreamWriter(rutaMail);
                    streamWriter.Write(mail);
                    streamWriter.Close();
                    help.enviarBackUp();
                    principal.nuevoTurno();

                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
    }
}
