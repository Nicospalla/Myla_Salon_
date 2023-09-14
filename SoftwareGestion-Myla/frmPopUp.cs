using Accesorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace SoftwareGestion_Myla
{
    public partial class frmPopUp : Form
    {
        Helpers help = new();
        bool status = false;
        CajaNegocio cajaNegocio = new();
        User aux;
        public frmPopUp(User user)
        {
            this.Visible = false;
            InitializeComponent();
            this.aux = user;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro desea salir?", "Cerrar programa", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            else
                Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEft.Text) && help.soloNum(txtEft.Text))
            {
                if (int.Parse(txtEft.Text) == 0)
                {
                    DialogResult result = MessageBox.Show("Seguro desea iniciar la caja en 0?", "Inicio de caja", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                cajaNegocio.activarCaja(DateTime.Today, int.Parse(txtEft.Text), aux);
                DateTime fechaA90 = (DateTime.Today).AddDays(-90) ;
                cajaNegocio.eliminarRegistros(fechaA90);
                frmPrincipal frmPrincipal = new frmPrincipal(aux);
                frmPrincipal.Show();
                this.Hide();

            }
            else
                lblErrorEft.Text = "Debe ingresar el efectivo existente en caja, o 0 para iniciar la caja vacía";
        }
    }
}
