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
    public partial class frmGrillaClientes : Form
    {
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        List<Clientes> clientes = new List<Clientes>();
        private frmPrincipal frmPrincipal;

        public frmGrillaClientes()
        {
            InitializeComponent();
        }
        public frmGrillaClientes(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
        }
        private void frmGrillaClientes_Load(object sender, EventArgs e)
        {
            clientes = clientesNegocio.listar();
            dgvGrillaClientes.DataSource = clientes;
            txtFiltroRapido.PlaceholderText = "Filtrar por Nombre, Apellido o Teléfono.";
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroRapido.Text.ToLower();
            List<Clientes> listaFiltrada;
            if (filtro.Length > 2)
            {
                listaFiltrada = clientes.FindAll(x => x.Nombre.ToLower().Contains(filtro) || x.Apellido.ToLower().Contains(filtro) || x.Telefono.Contains(filtro));
                dgvGrillaClientes.DataSource = listaFiltrada;

            }
            else
                dgvGrillaClientes.DataSource = clientes;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (dgvGrillaClientes.CurrentRow.DataBoundItem != null)
            {
                Clientes cliente = (Clientes)dgvGrillaClientes.CurrentRow.DataBoundItem;
                frmPrincipal.muestraHistorial(cliente.Id);
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (dgvGrillaClientes.CurrentRow.DataBoundItem != null)
            {
                Clientes cliente = (Clientes)dgvGrillaClientes.CurrentRow.DataBoundItem;
                frmPrincipal.nuevaVenta(cliente);
            }
        }

    }
}

