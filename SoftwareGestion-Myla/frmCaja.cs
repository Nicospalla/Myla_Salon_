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

    public partial class frmCaja : Form
    {
        public DateTime fechaElegida { get; set; }
        frmPrincipal form;
        CajaNegocio cajaNegocio = new CajaNegocio();
        Helpers help = new Helpers();
        public List<Caja> listaGrid { get; set; }
        public frmCaja(frmPrincipal form)
        {
            InitializeComponent();
            this.form = form;
            fechaElegida = DateTime.Today;
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            cambiosRb();
            cargaGrid();
            cargarResultados();
            rbIngresoEft.Checked = true;
            txtFecha.ReadOnly = true;
            txtApertura.ReadOnly = true;
            txtIngresos.ReadOnly = true;
            txtPagos.ReadOnly = true;
            txtRetiros.ReadOnly = true;
            txtTotalEft.ReadOnly = true;
            txtTotalTarj.ReadOnly = true;
            txtTotal.ReadOnly = true;
        }
        private void cargaGrid()
        {

            listaGrid = cajaNegocio.listarCajas(fechaElegida);
            dgvCaja.DataSource = null;
            if (rbIngresoEft.Checked)
            {
                dgvCaja.DataSource = listaGrid;
                dgvCaja.Columns["Retiro"].Visible = false;
                dgvCaja.Columns["RetiroMotivo"].Visible = false;
                dgvCaja.Columns["PagoProv"].Visible = false;
                dgvCaja.Columns["NombreProv"].Visible = false;
                dgvCaja.Columns["IdCaja"].Visible = false;
                dgvCaja.Columns["Estado"].Visible = false;

            }
            if (rbEgresoEft.Checked)
            {
                dgvCaja.DataSource = listaGrid;
                dgvCaja.Columns["Usuario"].Visible = false;
                dgvCaja.Columns["Inicio"].Visible = false;
                dgvCaja.Columns["Ingreso"].Visible = false;
                dgvCaja.Columns["PagoTarjeta"].Visible = false;
                dgvCaja.Columns["PagoEfectivo"].Visible = false;
                dgvCaja.Columns["Cliente"].Visible = false;
                dgvCaja.Columns["Especialista"].Visible = false;
                dgvCaja.Columns["IdCaja"].Visible = false;
                dgvCaja.Columns["Estado"].Visible = false;
            }


        }

        private void cambiosRb()
        {
            lblErrorPago.Text = string.Empty;
            lblErrorCaja.Text = string.Empty;
            lblErrorIngreso.Text = string.Empty;
            lblErrorRetiro.Text = string.Empty;
            if (rbIngreso.Checked)
            {
                txtIngreso.Enabled = true;
            }
            else
            {
                txtIngreso.Enabled = false;
                txtIngreso.Text = string.Empty;
            }
            if (rbPago.Checked)
            {
                txtPagoProv.Enabled = true;
                txtNombreProv.Enabled = true;
            }
            else
            {
                txtPagoProv.Enabled = false;
                txtNombreProv.Enabled = false;
                txtPagoProv.Text = string.Empty;
                txtNombreProv.Text = string.Empty;
            }
            if (rbRetiro.Checked)
            {
                txtRetiro.Enabled = true;
                txtMotivo.Enabled = true;
            }
            else
            {
                txtRetiro.Enabled = false;
                txtMotivo.Enabled = false;
                txtRetiro.Text = string.Empty;
                txtMotivo.Text = string.Empty;
            }
            if (rbCambioCaja.Checked)
            {
                txtCaja.Enabled = true;
            }
            else
            {
                txtCaja.Enabled = false;
                txtCaja.Text = string.Empty;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool status = true;

            if (!help.soloNum(txtIngreso.Text))
            {
                lblErrorIngreso.Text = "Solo números";
                status = false;
            }
            else
                lblErrorIngreso.Text = string.Empty;
            if (!help.soloNum(txtCaja.Text))
            {
                lblErrorCaja.Text = "Solo números";
                status = false;
            }
            else
                lblErrorCaja.Text = string.Empty;

            if (!help.soloNum(txtRetiro.Text))
            {
                lblErrorRetiro.Text = "Solo números";
                status = false;
            }
            else
                lblErrorRetiro.Text = string.Empty;
            if (!help.soloNum(txtPagoProv.Text))
            {
                lblErrorPago.Text = "Solo números";
                status = false;
            }
            else
                lblErrorPago.Text = string.Empty;

            if (!status)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Esta seguro que desea guardar el movimiento?", "Guardar movimiento de efectivo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            int efectivo = 0;
            int index = 0;
            string motivo = "";
            User user = form.user;
            DateTime fecha = calendar.SelectionStart;
            if (rbCambioCaja.Checked)
            {
                efectivo = int.Parse(txtCaja.Text);
                index = 1;
                cajaNegocio.movimientosCaja(efectivo, index, fecha, user);
            }
            else if (rbIngreso.Checked)
            {
                efectivo = int.Parse(txtIngreso.Text);
                index = 2;
                cajaNegocio.movimientosCaja(efectivo, index, fecha, user);
            }
            else if (rbRetiro.Checked)
            {
                efectivo = int.Parse(txtRetiro.Text);
                motivo = txtMotivo.Text;
                index = 3;
                cajaNegocio.movimientosCaja(efectivo, index, fecha, user, motivo);
            }
            else if (rbPago.Checked)
            {
                efectivo = int.Parse(txtPagoProv.Text);
                motivo = txtNombreProv.Text;
                index = 4;
                cajaNegocio.movimientosCaja(efectivo, index, fecha, user, motivo);
            }
            cargaGrid();
        }

        private void cargarResultados()
        {
            txtFecha.Text = calendar.SelectionStart.ToString("dd/MMM/yy");
            int apertura =0;
            int ingresos =0;
            int pagos =0;
            int retiros =0;
            int totalPagoEft =0;
            int totalTarjeta =0;
            int TOTAL =0;
            for (int i = 0; i < listaGrid.Count; i++)
            {
                apertura += listaGrid[i].Inicio;
                ingresos += listaGrid[i].Ingreso;
                pagos += listaGrid[i].PagoProv;
                retiros += listaGrid[i].Retiro;
                totalTarjeta += listaGrid[i].PagoTarjeta;
                totalPagoEft += listaGrid[i].PagoEfectivo;

            }
            
            TOTAL =  totalTarjeta + totalPagoEft + apertura + ingresos - pagos - retiros; ;
            txtApertura.Text = apertura.ToString();
            txtIngresos.Text = ingresos.ToString();
            txtPagos.Text = pagos.ToString();
            txtRetiros.Text = retiros.ToString();
            txtTotalEft.Text = totalPagoEft.ToString();
            txtTotalTarj.Text = totalTarjeta.ToString();
            txtTotal.Text = TOTAL.ToString();
        }


        private void rbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            cambiosRb();
        }

        private void rbRetiro_CheckedChanged(object sender, EventArgs e)
        {
            cambiosRb();
        }

        private void rbPago_CheckedChanged(object sender, EventArgs e)
        {
            cambiosRb();
        }

        private void rbCambioCaja_CheckedChanged(object sender, EventArgs e)
        {
            cambiosRb();
        }

        private void rbIngresoEft_CheckedChanged(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void rbEgresoEft_CheckedChanged(object sender, EventArgs e)
        {
            cargaGrid();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaElegida = calendar.SelectionStart.Date;
            cargaGrid();
            cargarResultados();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            form.nuevoTurno();
        }
    }
}
