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
    public partial class frmHistorial : Form
    {
        List<HistoVentas> listaVentas;
        HistoVentasNegocio histoVentasNegocio = new ();
        private frmPrincipal frm;
        public Clientes cliente { get; set; }
        public frmHistorial(Clientes clientes, frmPrincipal frm)
        {
            InitializeComponent();
            this.cliente = clientes;
            this.frm = frm;

        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            listaVentas = histoVentasNegocio.buscaHistorial(cliente.Id);
            dgvHistorial.DataSource = listaVentas;
            dgvHistorial.Columns["IdVenta"].Visible = false;
            dgvHistorial.Columns["IdCliente"].Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frm.verGrilla();
        }

        private void btnEditaVta_Click(object sender, EventArgs e)
        {
            HistoVentas venta = (HistoVentas)dgvHistorial.CurrentRow.DataBoundItem;
            frm.nuevaVenta(cliente, venta);
        }
    }
}
