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
        HistoVentasNegocio histoVentasNegocio = new HistoVentasNegocio();
        private frmPrincipal frm;
        public int IdCliente { get; set; }
        public frmHistorial(int id, frmPrincipal frm)
        {
            InitializeComponent();
            this.IdCliente = id;
            this.frm = frm;

        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            listaVentas = histoVentasNegocio.buscaHistorial(IdCliente);
            dgvHistorial.DataSource = listaVentas;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frm.verGrilla();
        }

  
    }
}
