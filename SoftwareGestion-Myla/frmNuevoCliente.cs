using Accesorios;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
        Helpers help = new Helpers();
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
                bool banderaC = true;
                try
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                        aux.Nombre = txtNombre.Text;
                    else
                    {
                        lblErrorNombre.Text = "El Nombre es obligatorio";
                        banderaC = false;
                    }
                    if (!string.IsNullOrEmpty(txtApellido.Text))
                        aux.Apellido = txtApellido.Text;
                    else
                    {
                        lblErrorApellid.Text = "El apellido es obligatorio";
                        banderaC = false;
                    }
                    if (help.validEmail(txtEmail.Text))
                    {
                        aux.Email = txtEmail.Text;
                        lblErrorMail.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorMail.Text = "Ingrese un email correcto";
                        banderaC = false;
                    }

                    if (string.IsNullOrEmpty(txtTel.Text) && help.soloNum(txtTel.Text) && !(txtTel.Text.Contains(",") || txtTel.Text.Contains(".")))
                    {
                        aux.Telefono = txtTel.Text;
                        lblErrorTel.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorTel.Text = "Debe ingresar un numero válido como teléfono";
                        banderaC = false;
                    }

                    aux.Cumple = datePickerCumple.Value.Date;
                    if (banderaC)
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
                Especialista aux = new Especialista();
                bool bandera = true;
                try
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                        aux.Nombre = txtNombre.Text;
                    else
                    {
                        lblErrorNombre.Text = "El Nombre es obligatorio";
                        bandera = false;
                    }
                    if (!string.IsNullOrEmpty(txtApellido.Text))
                        aux.Apellido = txtApellido.Text;
                    else
                    {
                        lblErrorApellid.Text = "El apellido es obligatorio";
                        bandera = false;
                    }
                    aux.Cumple = datePickerCumple.Value.Date;
                    if (help.validEmail(txtEmail.Text))
                    {
                        aux.Email = txtEmail.Text;
                        lblErrorMail.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorMail.Text = "Ingrese un email correcto";
                        bandera = false;
                    }

                    if (string.IsNullOrEmpty(txtTel.Text) && help.soloNum(txtTel.Text) && !(txtTel.Text.Contains(",") || txtTel.Text.Contains(".")))
                    {
                        aux.Telefono = txtTel.Text;
                        lblErrorTel.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorTel.Text = "Debe ingresar un numero válido como teléfono";
                        bandera = false;
                    }

                    if (help.soloNum(txtSueldo.Text))
                    {
                        aux.Sueldo = txtSueldo.Text != "" ? Decimal.Parse(txtSueldo.Text) : 0;
                        lblErrorSueldo.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorSueldo.Text = "Solo puede ingresar números enteros y un separador decimal.";
                        bandera = false;
                    }

                    if (help.soloNum(txtPorcentaje.Text))
                    {
                        aux.Porcentaje = txtPorcentaje.Text != "" ? double.Parse(txtPorcentaje.Text) : 0;
                        lblErrorPorcen.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorPorcen.Text = "Solo puede ingresar números enteros y un separador decimal.";
                        bandera = false;
                    }


                    if (bandera)
                    {
                        int id = especialistaNegocio.nuevoEsp(aux);
                        aux.IdEspecialista = id;
                    }
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
