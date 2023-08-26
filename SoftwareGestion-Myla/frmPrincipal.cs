
using Dominio;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;


namespace SoftwareGestion_Myla
{

    public partial class frmPrincipal : Form
    {

        public User user { get; set; }

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
            //if (user.Admin == true)
            //{
            //    btnGrillaClientes.Enabled = true;
            //}
            //else
            //    btnGrillaClientes.Enabled = false;
            verGrilla();
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
            Application.Exit();
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

        public void muestraHistorial(int id)
        {
            limpiaPanel();
            frmHistorial frmHistorial = new frmHistorial(id, this);
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
        public void nuevaVenta(Clientes cliente)
        {
            limpiaPanel();
            frmNuevaVenta frmNuevaVenta = new frmNuevaVenta(cliente, this);
            frmNuevaVenta.TopLevel = false;
            panelPpal.Controls.Add(frmNuevaVenta);
            frmNuevaVenta.Dock = DockStyle.Fill;
            frmNuevaVenta.Location = new Point((panelPpal.Width - frmNuevaVenta.Width) / 2, (panelPpal.Height - frmNuevaVenta.Height) / 2);
            frmNuevaVenta.Show();
        }

        private void btnNuevoEsp_Click(object sender, EventArgs e)
        {
            limpiaPanel();
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente(this, false);
            frmNuevoCliente.TopLevel = false;
            panelPpal.Controls.Add(frmNuevoCliente);
            frmNuevoCliente.Dock = DockStyle.Fill;
            frmNuevoCliente.Location = new Point((panelPpal.Width - frmNuevoCliente.Width) / 2, (panelPpal.Height - frmNuevoCliente.Height) / 2);
            frmNuevoCliente.Show();
        }
    }
}