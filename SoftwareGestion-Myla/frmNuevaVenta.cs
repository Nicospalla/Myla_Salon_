using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGestion_Myla
{
    public partial class frmNuevaVenta : Form
    {
        private frmPrincipal FrmPrincipal;
        private Clientes cliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        EspecialistaNegocio EspecialistaNegocio = new EspecialistaNegocio();
        Especialistas_Categorias_Negocio Especialistas_Categorias_Negocio = new Especialistas_Categorias_Negocio();
        HistoVentasNegocio ventasNegocio = new HistoVentasNegocio();
        public frmNuevaVenta(Clientes cliente, frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = frmPrincipal;
            this.cliente = cliente;
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            txtCliente.ReadOnly = true;
            txtCliente.Text = cliente.Nombre;
            cboCategoria.DataSource = categoriaNegocio.listarCat();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.SelectedIndex = -1;

            //cboEspecialista.DataSource = EspecialistaNegocio.listaEspecialista();
            //cboEspecialista.ValueMember = "Nombre";
        }

        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1)
            {
                Categorias cat = (Categorias)cboCategoria.SelectedValue;
                int id = cat.idCat;
                cboEspecialista.DataSource = Especialistas_Categorias_Negocio.listarEspCat(id);
                cboEspecialista.ValueMember = "IdEspecialista";
                cboEspecialista.DisplayMember = "Nombre";
                cboEspecialista.SelectedIndex = -1;

                cboSubCat.DataSource = SubCategoriaNegocio.listarSubCat(id);
                cboSubCat.DisplayMember = "Descripcion";
                cboSubCat.ValueMember = "IdSub";
                cboSubCat.SelectedIndex = -1;

            }
            else
            {
                cboEspecialista.DataSource = null;
                cboEspecialista.SelectedIndex = -1;
                cboSubCat.DataSource = null;
                cboSubCat.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea borrar los datos?", "Volver a grilla principal", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                FrmPrincipal.verGrilla();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool status = true;
            status = cboCategoria.SelectedIndex != -1 ? status : false;
            lblErrorCat.Text = cboCategoria.SelectedIndex == -1 ? "Debe seleccionar una Categoria" : "";
            status = cboEspecialista.SelectedIndex != -1 ? status : false;
            lblErrorEspe.Text = cboEspecialista.SelectedIndex == -1 ? "Debe seleccionar un Especialista" : "";
            if (status == false)
            {
                MessageBox.Show("Por favor revise los datos.", "Faltan datos", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Esta segura de guardar ésta nueva venta?", "Nueva venta", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    HistoVentas venta = new HistoVentas();

                    venta.IdCat = new Categorias();
                    Categorias cat = (Categorias)cboCategoria.SelectedValue;
                    venta.IdCat.idCat = cat.idCat;

                    venta.IdCliente = cliente.Id;

                    venta.Especialista =new Especialista();
                    //Especialista esp = (Especialista)cboEspecialista.SelectedValue;
                    //venta.Especialista.IdEspecialista = esp.IdEspecialista;
                    venta.Especialista.IdEspecialista = (int)cboEspecialista.SelectedValue;

                    venta.CodigoTinte = txtCodigoTinte.Text;
                    venta.Precio = txtPrecio.Text != "" ? Math.Truncate(Decimal.Parse(txtPrecio.Text)*100)/100 : 0;
                    venta.Fecha = DateTime.Today;

                    venta.IdSub = new SubCategoria();
                    //SubCategoria sub = (SubCategoria)cboSubCat.SelectedValue;
                    venta.IdSub.idCategoria = (int)cboSubCat.SelectedValue != -1 ? (int)cboSubCat.SelectedValue : -1;

                    venta.ServicioAdicional = txtServAdc.Text;
                    ventasNegocio.nuevaVenta(venta);
                }

            }
        }
    }
}


