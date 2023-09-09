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
        private bool esCliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio subCategoriaNegocio = new SubCategoriaNegocio();
        Helpers help = new Helpers();
        Clientes? cliente;
        public frmNuevoCliente(frmPrincipal frmPrincipal, bool EsCliente, Clientes cliente = null)
        {
            InitializeComponent();
            this.form = frmPrincipal;
            Anchor = AnchorStyles.Right;
            this.esCliente = EsCliente;
            this.cliente = cliente;
        }
        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            if (esCliente && cliente == null)
            {
                lblTitulo.Text = "Nuevo Cliente:";
                pnlEsp.Visible = false;
            }
            else if (esCliente && cliente != null)
            {
                lblTitulo.Text = "Editar Cliente:";
                pnlEsp.Visible = false;
                completarModif(cliente);
            }
            else if (!esCliente)
            {
                lblTitulo.Text = "Nuevo Especialista:";
                pnlEsp.Visible = true;
            }
            if (cliente != null)
            {
                btnLimpiar.Text = "Cancelar";               
            }
        }

        private void completarModif(Clientes cliente)
        {
            this.cliente = cliente;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtEmail.Text = cliente.Email;
            txtTel.Text = cliente.Telefono.ToString();
            datePickerCumple.Value = cliente.Cumple;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (esCliente)
            {
                Clientes aux;
                ClientesNegocio clientesNegocio = new ClientesNegocio();
                if (cliente != null)
                {
                    aux = cliente;
                }
                else
                {
                    aux = new Clientes();
                }
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

                    if (help.validEmail(txtEmail.Text) || string.IsNullOrEmpty(txtEmail.Text))
                    {
                        aux.Email = txtEmail.Text;
                        lblErrorMail.Text = string.Empty;
                    }
                    else
                    {
                        lblErrorMail.Text = "Ingrese un email correcto";
                        banderaC = false;
                    }

                    if (!string.IsNullOrEmpty(txtTel.Text) && help.soloNum(txtTel.Text) && (!txtTel.Text.Contains(",") && !txtTel.Text.Contains(".")))
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
                        if (cliente != null)
                        {
                            clientesNegocio.editarCliente(aux);
                        }
                        else
                        {
                            clientesNegocio.crearCliente(aux);
                        }
                        form.verGrilla();
                    }
                    else
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }
            else if (!esCliente)
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
                    if (help.validEmail(txtEmail.Text) || string.IsNullOrEmpty(txtEmail.Text))
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
            if(cliente!= null)
            {
                form.verGrilla();
            }
            else
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



        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            form.verGrilla();
        }

    }
}
