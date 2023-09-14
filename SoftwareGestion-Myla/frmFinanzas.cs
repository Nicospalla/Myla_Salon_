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

    public partial class frmFinanzas : Form
    {
        EspecialistaNegocio especialistaNegocio = new();
        HistoVentasNegocio ventasNegocio = new();
        public Decimal totalFact { get; set; }
        Helpers help = new();
        frmPrincipal form;
        public frmFinanzas(frmPrincipal form)
        {
            InitializeComponent();
            rbCalendar.Checked = true;
            this.form = form;
        }

        private void rbCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCalendar.Checked)
            {
                pnlCalendario.Visible = true;
                pnlFechas.Visible = false;
            }
            else if (rbDosFechas.Checked)
            {
                pnlCalendario.Visible = false;
                pnlFechas.Visible = true;
            }
        }

        private void frmFinanzas_Load(object sender, EventArgs e)
        {
            var especialistas = especialistaNegocio.listaEspecialista().ToList();
            especialistas.Insert(0, new Especialista { IdEspecialista = 0, Nombre = "Todos" });
            cboEspe.DataSource = especialistas;
            if (txtCostoFijo.Text.Length == 0)
            {
                txtCostoFijo.Text = "0";
            }
        }

        private void muestraGrid()
        {
            DateTime fechaInicio = new();
            DateTime fechaFin = new();
            if (rbCalendar.Checked)
            {
                fechaInicio = calendarFecha.SelectionStart.Date;
                fechaFin = calendarFecha.SelectionEnd.Date;
            }
            else if (rbDosFechas.Checked)
            {
                fechaInicio = dateTime1.Value;
                fechaFin = dateTime2.Value;
            }
            Especialista auxEspe = (Especialista)cboEspe.SelectedItem;
            List<HistoVentas> listaAux = ventasNegocio.buscaHistorial(0, auxEspe, fechaInicio, fechaFin);
            dataGridHisto.DataSource = listaAux;
            dataGridHisto.Columns["IdVenta"].Visible = false;
            dataGridHisto.Columns["IdCliente"].Visible = false;
            dataGridHisto.Columns["ServicioAdicional"].Visible = false;
            dataGridHisto.Columns["CodigoTinte"].Visible = false;
            totalFact = 0;
            for (int i = 0; i < listaAux.Count; i++)
            {
                totalFact += listaAux[i].Precio;
            }
            txtTotal.Text = "$ " + totalFact;
        }

        private void dateTime2_ValueChanged(object sender, EventArgs e)
        {
            defineEsp();
            muestraGrid();
            calculaPagar();
        }

        private void dateTime1_ValueChanged(object sender, EventArgs e)
        {
            defineEsp();
            muestraGrid();
            calculaPagar();
        }

        private void calendarFecha_DateSelected(object sender, DateRangeEventArgs e)
        {
            defineEsp();
            muestraGrid();
            calculaPagar();
        }
        private void txtCostoFijo_TextChanged(object sender, EventArgs e)
        {
            defineEsp();
            muestraGrid();
            calculaPagar();
            if(txtCostoFijo.Text.Length == 0) 
            {
                txtCostoFijo.Text = "0";
            }
        }

        private void cboEspe_SelectionChangeCommitted(object sender, EventArgs e)
        {

            defineEsp();
            muestraGrid();
            calculaPagar();

        }
        private void defineEsp()
        {
            Especialista esp = (Especialista)cboEspe.SelectedItem;
            txtSueldo.Text = "$ " + esp.Sueldo.ToString();
            txtSueldo2.Text = "$ " + esp.Sueldo.ToString();
            txtComi.Text = esp.Porcentaje.ToString() + " %";
            txtComi2.Text = esp.Porcentaje.ToString() + " %";
        }
        private void calculaPagar()
        {
            Especialista esp = (Especialista)cboEspe.SelectedItem;
            Decimal totalPagar = 0;
            Decimal totalFacturado = totalFact;
            
            if (help.soloNum(txtCostoFijo.Text) && txtCostoFijo.Text != "")
            {
                totalFacturado = totalFacturado - (totalFacturado * decimal.Parse(txtCostoFijo.Text)) / 100;
            }
            totalPagar = (totalFacturado - esp.Sueldo);
            totalPagar = Math.Truncate((totalPagar * (Decimal)esp.Porcentaje) / 100);
            if(totalPagar < 0) 
                totalPagar = 0;

            txtResta.Text = totalPagar.ToString();
            }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            form.nuevoTurno();
        }
    }
}
