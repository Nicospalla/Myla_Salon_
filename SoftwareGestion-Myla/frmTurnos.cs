using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace SoftwareGestion_Myla
{
    public partial class frmTurnos : Form
    {
        TurnosNegocio turnosNegocio = new TurnosNegocio();
        EspecialistaNegocio especialistaNegocio = new EspecialistaNegocio();
        ClientesNegocio ClientesNegocio = new ClientesNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        public Clientes cliente { get; set; }
        public frmTurnos(Clientes? cliente = null)
        {
            InitializeComponent();
            if (cliente != null)
            {
                this.cliente = cliente;
            }
        }
        private void frmTurnos_Load(object sender, EventArgs e)
        {

            pnlEdit.Visible = false;
            pnlGrid.Visible = true;
            txtNombre.ReadOnly = true;
            cargaCboEsp();
            if (cliente != null)
            {
                this.cliente = cliente;
                txtIdCliente.Text = cliente.Id.ToString();
                chequeaId();
                pnlEdit.Visible = true;
                pnlGrid.Visible = false;





            }


        }
        private void cargaCboEsp()
        {
            var especialistas = especialistaNegocio.listaEspecialista().ToList();

            especialistas.Insert(0, new Especialista { IdEspecialista = 0, Nombre = "Todos" });
            cboEspeVerTurnos.DataSource = especialistas;
        }

        private void btnVerTurnos_Click(object sender, EventArgs e)
        {
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = turnosNegocio.listarTurnos(calendarTurno.SelectionStart.Date);
        }

        private void chequeaId()
        {
            if (txtIdCliente.Text.Length > 0)
            {
                List<Clientes> listaAux = ClientesNegocio.listar(int.Parse(txtIdCliente.Text));
                if (listaAux.Count == 1)
                {
                    Clientes aux = listaAux[0];
                    cboEspe.DataSource = especialistaNegocio.listaEspecialista();
                    cboEspe.SelectedIndex = -1;
                    txtNombre.Text = aux.Nombre + " " + aux.Apellido;
                    lblErrorId.Text = "";
                }
                else
                {
                    limpiaPlanilla();
                    lblErrorId.Text = "Ese número de Cliente parece no existir, intente con otro.";
                }
            }
            else
            {
                limpiaPlanilla();
                lblErrorId.Text = "Ese número de Cliente parece no existir, intente con otro.";
            }
        }

        private void limpiaPlanilla()
        {
            txtIdCliente.Text = string.Empty;
            cboEspe.DataSource = null;
            cboSubCat.DataSource = null;
            txtNombre.Text = string.Empty;
            cboHorarios.DataSource = null;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            chequeaId();
        }

        private void cboEspe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int idEsp = ((Especialista)cboEspe.SelectedValue).IdEspecialista;
            cboSubCat.DataSource = SubCategoriaNegocio.listarSubCat(idEsp, 0, true);
            cboSubCat.SelectedIndex = -1;

            cargaCboHorarios(calendarTurno.SelectionStart);
        }
        public void cargaCboHorarios(DateTime fecha)
        {
            DateTime horaInicio = DateTime.Today.AddHours(10);
            DateTime horaFin = DateTime.Today.AddHours(20);
            List<string> horariosDisponibles = new List<string>();

            while(horaInicio <= horaFin)
            {
                string hora = horaInicio.ToString("HH:mm");
                
                if (turnosNegocio.verifDisponible(fecha, hora))
                {
                    horariosDisponibles.Add(hora);
                }

                horaInicio = horaInicio.AddMinutes(15);
            }
            cboHorarios.DataSource = horariosDisponibles;
        }
       

        private void btnAtras_Click(object sender, EventArgs e)
        {

            limpiaPlanilla();
            pnlEdit.Visible = false;
            pnlGrid.Visible = true;

        }

        private void cboEspeVerTurnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnVerTurnos.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiaPlanilla();
            pnlEdit.Visible = false;
            pnlGrid.Visible = true;
            //dgvTurnos.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlGrid.Visible = false;
            DateTime fecha = calendarTurno.SelectionStart.Date;

        }
    }
}
