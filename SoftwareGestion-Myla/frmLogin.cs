using Accesorios;
using Dominio;
using Negocio;
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
    public partial class frmLogin : Form
    {
        CajaNegocio cajaNegocio = new();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UserNegocio userNegocio = new UserNegocio();
            User aux;
            try
            {
                aux = userNegocio.getUser(txtUser.Text, txtPass.Text);
                if (aux.Id != 0)
                {
                    if(cajaNegocio.cajaActiva(DateTime.Today) == false)
                    {
                        frmPopUp popUp = new frmPopUp(aux);
                        popUp.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(aux);
                        frmPrincipal.Show();
                        this.Hide();

                    }

                }
                else
                    lblError.Text = "Datos incorrectos o usuario inexistente.";



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
