
using Dominio;
using Negocio;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;


namespace SoftwareGestion_Myla
{

    public partial class frmPrincipal : Form
    {

        public User user { get; set; }
        CajaNegocio cajaNegocio = new();
        private Timer ti;
        public frmPrincipal(User user)
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            this.user = user;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            TextInfo textInfo = new CultureInfo("en-US").TextInfo;
            lblUser.Text = textInfo.ToTitleCase(user.Usuario);
            string ruta = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Imgs", "MYLA.jpeg");
            //picBox.ImageLocation = "D:\\Proyectos Csharp\\Myla Salon\\SoftwareGestion-Myla\\Imgs\\MYLA.jpeg";
            picBox.Load(ruta);



            if (user.Admin == false)
           
            {
                btnEditarEsp.Enabled = false;
                btnNuevoEsp.Enabled = false;
                btnCategorias.Enabled = false;
                btnFinanzas.Enabled = false;
                btnUsuarios.Enabled = false;
            }

            //verGrilla();
            nuevoTurno();
        }

        private void eventoTimer(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblReloj.Text = dt.ToString("HH:mm:ss");
            lblFecha.Text = dt.ToString("dd/MM/yy");
        }

        private void btnGrillaClientes_Click(object sender, EventArgs e)
        {
            verGrilla();
        }
        public void verGrilla()
        {

            limpiaPanel();
            frmGrillaClientes frmGrillaClientes = new frmGrillaClientes(this);
            frmGrillaClientes.TopLevel = false;
            panelPpal.Controls.Add(frmGrillaClientes);
            frmGrillaClientes.Dock = DockStyle.Fill;
            frmGrillaClientes.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resulta = MessageBox.Show("Seguro desea salir?", "Cerrar sistema", MessageBoxButtons.OKCancel);
            if (resulta == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnCerrarSession_Click(object sender, EventArgs e)
        {
            user = null;
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();

        }

        private void limpiaPanel()
        {
            if (panelPpal.Controls.Count > 0)
            {
                panelPpal.Controls.Clear();
            }
        }

        public void muestraHistorial(Clientes cliente)
        {
            limpiaPanel();
            frmHistorial frmHistorial = new frmHistorial(cliente, this);
            frmHistorial.TopLevel = false;
            panelPpal.Controls.Add(frmHistorial);
            frmHistorial.Dock = DockStyle.Fill;
            frmHistorial.Show();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente(this, true);
            frmNuevoCliente.TopLevel = false;
            panelPpal.Controls.Add(frmNuevoCliente);
            frmNuevoCliente.Dock = DockStyle.Fill;
            frmNuevoCliente.Location = new Point((panelPpal.Width - frmNuevoCliente.Width) / 2, (panelPpal.Height - frmNuevoCliente.Height) / 2);
            frmNuevoCliente.Show();
        }
        public void nuevaVenta(Clientes cliente, HistoVentas? ventas = null)
        {
            limpiaPanel();
            frmNuevaVenta frmNuevaVenta = new frmNuevaVenta(this, cliente, ventas);
            frmNuevaVenta.TopLevel = false;
            panelPpal.Controls.Add(frmNuevaVenta);
            frmNuevaVenta.Dock = DockStyle.Fill;
            frmNuevaVenta.Location = new Point((panelPpal.Width - frmNuevaVenta.Width) / 2, (panelPpal.Height - frmNuevaVenta.Height) / 2);
            frmNuevaVenta.Show();
        }

        private void btnNuevoEsp_Click(object sender, EventArgs e)
        {
            if(user.Admin == false)
                btnNuevoEsp.Enabled = false;
            limpiaPanel();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente(this, false);
            frmNuevoCliente.TopLevel = false;
            panelPpal.Controls.Add(frmNuevoCliente);
            frmNuevoCliente.Dock = DockStyle.Fill;
            frmNuevoCliente.Location = new Point((panelPpal.Width - frmNuevoCliente.Width) / 2, (panelPpal.Height - frmNuevoCliente.Height) / 2);
            frmNuevoCliente.Show();
        }

        public void editarEsp(Especialista esp)
        {

            limpiaPanel();
            frmEspecialistas frmEspecialistas = new frmEspecialistas(this, esp);
            frmEspecialistas.TopLevel = false;
            panelPpal.Controls.Add(frmEspecialistas);
            frmEspecialistas.Dock = DockStyle.Fill;
            frmEspecialistas.Show();
        }

        private void btnEditarEsp_Click(object sender, EventArgs e)
        {
            Especialista? esp = null;
            editarEsp(esp);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            nuevoTurno();
        }

        public void nuevoTurno(Clientes? cliente = null)
        {
            limpiaPanel();
            frmTurnos frmTurnos = new frmTurnos(cliente);
            frmTurnos.TopLevel = false;
            panelPpal.Controls.Add(frmTurnos);
            frmTurnos.Dock = DockStyle.Fill;
            frmTurnos.Show();
        }

        public void editarCliente(Clientes cliente)
        {
            limpiaPanel();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente(this, true, cliente);
            frmNuevoCliente.TopLevel = false;
            panelPpal.Controls.Add(frmNuevoCliente);
            frmNuevoCliente.Dock = DockStyle.Fill;
            frmNuevoCliente.Location = new Point((panelPpal.Width - frmNuevoCliente.Width) / 2, (panelPpal.Height - frmNuevoCliente.Height) / 2);
            frmNuevoCliente.Show();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmCategorias frmCategorias = new frmCategorias();
            frmCategorias.TopLevel = false;
            panelPpal.Controls.Add(frmCategorias);
            frmCategorias.Dock = DockStyle.Fill;
            frmCategorias.Location = new Point((panelPpal.Width - frmCategorias.Width) / 2, (panelPpal.Height - frmCategorias.Height) / 2);
            frmCategorias.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmNuevaVenta frmNuevaVenta = new frmNuevaVenta(this);
            frmNuevaVenta.TopLevel = false;
            panelPpal.Controls.Add(frmNuevaVenta);
            frmNuevaVenta.Dock = DockStyle.Fill;
            frmNuevaVenta.Location = new Point((panelPpal.Width - frmNuevaVenta.Width) / 2, (panelPpal.Height - frmNuevaVenta.Height) / 2);
            frmNuevaVenta.Show();
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmFinanzas frmFinanzas = new frmFinanzas(this);
            frmFinanzas.TopLevel = false;
            panelPpal.Controls.Add(frmFinanzas);
            frmFinanzas.Dock = DockStyle.Fill;
            frmFinanzas.Location = new Point((panelPpal.Width - frmFinanzas.Width) / 2, (panelPpal.Height - frmFinanzas.Height) / 2);
            frmFinanzas.Show();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmCaja frmCaja = new frmCaja(this);
            frmCaja.TopLevel = false;
            panelPpal.Controls.Add(frmCaja);
            frmCaja.Dock = DockStyle.Fill;
            frmCaja.Location = new Point((panelPpal.Width - frmCaja.Width) / 2, (panelPpal.Height - frmCaja.Height) / 2);
            frmCaja.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmUsuarios frmUsuarios = new frmUsuarios(this);
            frmUsuarios.TopLevel = false;
            panelPpal.Controls.Add(frmUsuarios);
            frmUsuarios.Dock = DockStyle.Fill;
            frmUsuarios.Location = new Point((panelPpal.Width - frmUsuarios.Width) / 2, (panelPpal.Height - frmUsuarios.Height) / 2);
            frmUsuarios.Show();
        }
    }
}