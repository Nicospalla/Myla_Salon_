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
    public partial class frmNuevoCliente : Form
    {
        private frmPrincipal form;
        public frmNuevoCliente(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.form = frmPrincipal;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClientesNegocio clientesNegocio = new ClientesNegocio();
            Clientes aux = new Clientes();
            try
            {
                aux.Nombre = txtNombre.Text;
                aux.Apellido = txtApellido.Text;
                aux.Email = txtEmail.Text;
                aux.Telefono = txtTel.Text;
                aux.Cumple = datePickerCumple.Value.Date;
                aux.UltContacto = DateTime.Today;
                clientesNegocio.crearCliente(aux);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                form.verGrilla();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           DialogResult result = MessageBox.Show("Esta seguro que desea limpia la planilla?", "Limpiar Datos", MessageBoxButtons.OKCancel);
           if(result == DialogResult.OK)
            {
                txtNombre.Text = null;
                txtApellido.Text = null;
                txtEmail.Text = null;
                txtTel.Text = null;
                datePickerCumple.Value = DateTime.Now;

            }
            else
            {
                return;
            }
        }
    }
}
