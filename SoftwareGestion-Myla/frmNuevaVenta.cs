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
    public partial class frmNuevaVenta : Form
    {
        private frmPrincipal FrmPrincipal;
        private Clientes cliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        EspecialistaNegocio EspecialistaNegocio = new EspecialistaNegocio();
        Especialistas_Categorias_Negocio Especialistas_Categorias_Negocio = new Especialistas_Categorias_Negocio();

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
            //cboEspecialista.DataSource = EspecialistaNegocio.listaEspecialista();
            //cboEspecialista.ValueMember = "Nombre";
        }

        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            Categorias cat = (Categorias)cboCategoria.SelectedValue;
            int id = cat.idCat;
            cboEspecialista.DataSource = Especialistas_Categorias_Negocio.listarEspCat(id);
            cboEspecialista.ValueMember = "Nombre";

        }

        private void cboSubCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
