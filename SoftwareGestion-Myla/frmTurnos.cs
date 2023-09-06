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
using System.Globalization;
using Microsoft.VisualBasic;

namespace SoftwareGestion_Myla
{
    public partial class frmTurnos : Form
    {
        TurnosNegocio turnosNegocio = new TurnosNegocio();
        EspecialistaNegocio especialistaNegocio = new EspecialistaNegocio();
        ClientesNegocio ClientesNegocio = new ClientesNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        List<Especialista> listaEsp;
        List<SubCategoria> listaSubCat;
        List<string> horariosDispo;
        public Turnos turno { get; set; }
        public bool Modificar { get; set; }
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

            txtNombre.ReadOnly = true;
            cargaCboEsp();
            if (cliente != null)
            {
                this.cliente = cliente;
                txtIdCliente.Text = cliente.Id.ToString();
                txtIdCliente.Enabled = false;
                chequeaId();
                pnlEdit.Visible = true;
                pnlGrid.Visible = false;

            }
            cboEstado.Items.Add("Reservado");
            cboEstado.Items.Add("Señado 10%");
            cboEstado.Items.Add("Señado 20%");


            turnosReservados();
        }

        private void cargaCboEsp()
        {
            var especialistas = especialistaNegocio.listaEspecialista().ToList();

            especialistas.Insert(0, new Especialista { IdEspecialista = 0, Nombre = "Todos" });
            cboEspeVerTurnos.DataSource = especialistas;
        }
        private void chequeaId()
        {
            if (txtIdCliente.Text.Length > 0)
            {
                List<Clientes> listaAux = ClientesNegocio.listar(int.Parse(txtIdCliente.Text));
                if (listaAux.Count == 1)
                {
                    Clientes aux = listaAux[0];
                    listaEsp = especialistaNegocio.listaEspecialista();
                    cboEspe.DataSource = listaEsp;
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
            bloqueaCBOS();
        }

        private void bloqueaCBOS()
        {
            if (cboSubCat.Items.Count == 0)
                cboSubCat.Enabled = false;
            else { cboSubCat.Enabled = true; }
            if (cboEspe.Items.Count == 0)
                cboEspe.Enabled = false;
            else { cboEspe.Enabled = true; }
            if (cboHorarios.Items.Count == 0 && Modificar == false)
                cboHorarios.Enabled = false;
            else { cboHorarios.Enabled = true; }
        }

        private void limpiaPlanilla()
        {
            Modificar = false;
            txtIdCliente.Text = string.Empty;
            cboEspe.DataSource = null;
            cboSubCat.DataSource = null;
            txtNombre.Text = string.Empty;
            cboHorarios.DataSource = null;
            lblTitulo.Text = string.Empty;
            lblErrorId.Text = string.Empty;
            lblErrorHora.Text = string.Empty;
            lblErrorSubCat.Text = string.Empty;
            lblErrorEsp.Text = string.Empty;
            cboEstado.SelectedIndex = -1;
            bloqueaCBOS();
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
            cargaCboHorarios(calendarTurno.SelectionStart, idEsp);
            bloqueaCBOS();
        }
        public void cargarCboSubCat()
        {
            int idEsp = ((Especialista)cboEspe.SelectedValue).IdEspecialista;
            listaSubCat = SubCategoriaNegocio.listarSubCat(idEsp, 0, true);
            cboSubCat.DataSource = listaSubCat;
            cboSubCat.SelectedIndex = -1;
            bloqueaCBOS();
        }
        public void cargaCboHorarios(DateTime fecha, int idEsp, int idTurno = 0)
        {

            TimeSpan horaInicio = TimeSpan.FromHours(10);
            TimeSpan horaFin = TimeSpan.FromHours(20);
            List<string> horariosDisponibles = new List<string>();

            TimeSpan intervalo = TimeSpan.FromMinutes(15);
            if(calendarTurno.SelectionStart == DateTime.Today)
            {
                TimeSpan horaHoy = DateTime.Now.TimeOfDay;
                int minutosRestantes = horaHoy.Minutes % 15;
                int minutosAjustados = 0;
                if(minutosRestantes != 0)
                {
                    minutosAjustados = horaHoy.Minutes + (15 - minutosRestantes);
                }
                TimeSpan horaRedondeada = new TimeSpan(horaHoy.Hours, minutosAjustados, horaHoy.Seconds);
                horaInicio = horaRedondeada;
            }
            while (horaInicio <= horaFin)
            {
                string hora = horaInicio.ToString(@"hh\:mm");
                if (turnosNegocio.verifDisponible(fecha, hora, idEsp, idTurno))
                {
                    horariosDisponibles.Add(hora);
                }
                horaInicio = horaInicio.Add(intervalo);
            }
            cboHorarios.DataSource = horariosDisponibles;
            horariosDispo = horariosDisponibles;
        }


        private void btnAtras_Click(object sender, EventArgs e)
        {

            limpiaPlanilla();
            pnlEdit.Visible = false;
            pnlGrid.Visible = true;
            dgvTurnos.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiaPlanilla();
            pnlEdit.Visible = false;
            pnlGrid.Visible = true;
            dgvTurnos.Focus();
            dgvTurnos.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardaTurno();
        }
        private void guardaTurno()
        {

            if (!verificaCampos(txtIdCliente.Text, cboEspe.SelectedIndex, cboSubCat.SelectedIndex))
            {
                return;
            }
            if (turno == null)
            {
                turno = new Turnos();
            }
            turno.Especialista = new Especialista();
            turno.Especialista.IdEspecialista = ((Especialista)cboEspe.SelectedValue).IdEspecialista;
            turno.Cliente = new Clientes();
            turno.Cliente.Id = int.Parse(txtIdCliente.Text);
            turno.SubCategoria = new SubCategoria();
            turno.SubCategoria.IdSub = ((SubCategoria)cboSubCat.SelectedValue).IdSub;
            turno.SubCategoria.Duracion = ((SubCategoria)cboSubCat.SelectedValue).Duracion;
            turno.Fecha = calendarTurno.SelectionStart;
            turno.Estado = cboEstado.SelectedItem.ToString();
            string horaI = cboHorarios.SelectedValue.ToString();
            turno.HoraInicio = TimeSpan.ParseExact(horaI, @"hh\:mm", CultureInfo.InvariantCulture);
            //turno.HoraInicio = TimeSpan.ParseExact(horaI, "HH:mm", CultureInfo.InvariantCulture);
            turno.HoraFin = turno.HoraInicio.Add(turno.SubCategoria.Duracion);


            TimeSpan quince = new TimeSpan(0, 15, 0);

            TimeSpan horaInicioAux = turno.HoraInicio;
            TimeSpan intervalo = TimeSpan.FromMinutes(15);
            TimeSpan horaCierre = TimeSpan.FromHours(20);
            bool banderaHora = true;

            while (horaInicioAux < turno.HoraFin)
            {
                string hora = horaInicioAux.ToString(@"hh\:mm");
                if (horaInicioAux == horaCierre)
                {
                    lblErrorHora.Text = "El turno se superpone con el horario de cierre.";
                    banderaHora = false;
                    break;
                }
                else if (turnosNegocio.verifDisponible(turno.Fecha, hora, turno.Especialista.IdEspecialista, turno.IdTurno))
                {
                    horaInicioAux = horaInicioAux.Add(intervalo);
                }
                else if (turnosNegocio.verifDisponible(turno.Fecha, hora, turno.Especialista.IdEspecialista))
                {
                    horaInicioAux = horaInicioAux.Add(intervalo);
                }
                else
                {
                    banderaHora = false;
                    lblErrorHora.Text = "El horario se superpone con otro reservado anteriormente";
                    break;
                }



            }
            if (banderaHora)
            {
                int idTurno = 0;
                if (Modificar == true)
                {
                    idTurno = turno.IdTurno;
                    turnosNegocio.defineTurnos(turno, idTurno, Modificar);
                }
                else
                    idTurno = turnosNegocio.defineTurnos(turno);

                while (turno.HoraInicio < turno.HoraFin)
                {
                    turno.HoraInicio += quince;
                    turnosNegocio.defineTurnos(turno, idTurno);
                }
            }
            else
            {
                return;
            }
            limpiaPlanilla();
            turnosReservados();
        }

        private bool verificaCampos(string id, int indexEsp, int indexSubCat)
        {
            bool verifFlag = true;
            if (string.IsNullOrEmpty(id))
            {
                lblErrorId.Text = "El Número de cliente parece no existir";
                verifFlag = false;
            }
            else
                lblErrorId.Text = string.Empty;

            if (!(indexEsp > -1))
            {
                lblErrorEsp.Text = "Debe seleccionar un Especialista";
                verifFlag = false;
            }
            else
                lblErrorEsp.Text = string.Empty;

            if (!(indexSubCat > -1))
            {
                lblErrorSubCat.Text = "Debe seleccionar una SubCategoria";
                verifFlag = false;
            }
            else
                lblErrorSubCat.Text = string.Empty;

            return verifFlag;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaPlanilla();
            pnlEdit.Visible = true;
            pnlGrid.Visible = false;
            DateTime fecha = calendarTurno.SelectionStart.Date;

        }

        private void calendarTurno_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (pnlGrid.Visible == true)
            {
                turnosReservados();
            }
            else
            {
                if(cboEspe.SelectedIndex != -1)
                {
                    cargaCboHorarios(calendarTurno.SelectionStart, ((Especialista)cboEspe.SelectedValue).IdEspecialista);
                }
            }
        }

        private void btnTurnoReservado_Click(object sender, EventArgs e)
        {
            turnosReservados();
            pnlEdit.Visible = false;
            pnlGrid.Visible = true;
        }
        private void turnosReservados()
        {
            pnlGrid.Visible = true; pnlEdit.Visible = false;

            dgvTurnos.DataError += DgvTurnos_DataError;
            int idEsp = ((Especialista)cboEspeVerTurnos.SelectedValue).IdEspecialista;
            lblNombreEsp.Text = "Especialista seleccionado: " + cboEspeVerTurnos.SelectedValue.ToString();
            lblFecha.Text = "Fecha: " + calendarTurno.SelectionStart.Date.ToString("dd/MMM/yy");
            dgvTurnos.DataSource = null;
            dgvTurnos.DataSource = turnosNegocio.listarTurnos(calendarTurno.SelectionStart, idEsp);
            dgvTurnos.Columns["IdTurno"].Visible = false;
            dgvTurnos.Focus();

        }

        private void DgvTurnos_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            dgvTurnos.Focus();
            Modificar = true;
            lblTitulo.Text = "Modificar Turno";
            if (dgvTurnos.CurrentRow != null)
            {
                turno = (Turnos)dgvTurnos.CurrentRow.DataBoundItem;

                pnlGrid.Visible = false;
                pnlEdit.Visible = true;
                txtIdCliente.Text = turno.Cliente.Id.ToString();
                txtIdCliente.Enabled = false;
                chequeaId();
                txtNombre.Text = turno.Cliente.Nombre.ToString();
                int index = -1;
                for (int i = 0; i < listaEsp.Count; i++)
                {
                    if (listaEsp[i].IdEspecialista == turno.Especialista.IdEspecialista)
                        index = i;
                }
                cboEspe.SelectedIndex = index;
                cargarCboSubCat();
                for (int i = 0; i < listaSubCat.Count; i++)
                {
                    if (listaSubCat[i].IdSub == turno.SubCategoria.IdSub)
                    {
                        index = i;
                    }
                }
                cboSubCat.SelectedIndex = index;

                cboEstado.SelectedItem = turno.Estado;

                calendarTurno.SelectionStart = turno.Fecha;
                cargaCboHorarios(turno.Fecha, turno.Especialista.IdEspecialista, turno.IdTurno);
                if (horariosDispo.Contains(turno.HoraInicio.ToString(@"hh\:mm")))
                {
                    cboHorarios.SelectedItem = turno.HoraInicio.ToString(@"hh\:mm");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvTurnos.Focus();
            if (dgvTurnos.CurrentRow == null)
                return;

            Turnos turno = (Turnos)dgvTurnos.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Seguro desea eliminar éste turno?", "Eliminar turno", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {
                turnosNegocio.eliminarTurno(turno);
            }
            turnosReservados();
        }

        private void cboEspeVerTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlGrid.Visible == true)
            {
                turnosReservados();
            }
        }
    }
}
