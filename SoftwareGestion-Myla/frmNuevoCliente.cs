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
        private bool cliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio subCategoriaNegocio = new SubCategoriaNegocio();
        public frmNuevoCliente(frmPrincipal frmPrincipal, bool cliente)
        {
            InitializeComponent();
            this.form = frmPrincipal;
            Anchor = AnchorStyles.Right;
            this.cliente = cliente;
        }
        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            if (cliente)
            {
                lblTitulo.Text = "Nuevo Cliente:";
                pnlEsp.Visible = false;
            }
            else if (!cliente)
            {
                lblTitulo.Text = "Nuevo Especialista:";
                pnlEsp.Visible = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cliente)
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
                    if (cliente)
                    {
                        aux.UltContacto = DateTime.Today;
                        clientesNegocio.crearCliente(aux);
                    }
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
            else if (!cliente)
            {
                EspecialistaNegocio especialistaNegocio = new EspecialistaNegocio();
                Especialistas_Categorias auxCatSub = new Especialistas_Categorias();
                Especialista aux = new Especialista();
                try
                {
                    aux.Nombre = txtNombre.Text;
                    aux.Apellido = txtApellido.Text;
                    aux.Email = txtEmail.Text;
                    aux.Telefono = txtTel.Text;
                    aux.Cumple = datePickerCumple.Value.Date;
                    int id = especialistaNegocio.nuevoEsp(aux);
                    aux.IdEspecialista = id;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    form.editarEsp(aux);
                }


            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea limpia la planilla?", "Limpiar Datos", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            form.verGrilla();
        }


    }
}
