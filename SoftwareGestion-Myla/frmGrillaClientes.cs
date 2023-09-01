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
using System.Threading;
using System.Runtime.Intrinsics.X86;
using Timer = System.Windows.Forms.Timer;

namespace SoftwareGestion_Myla
{
    public partial class frmGrillaClientes : Form
    {
        ClientesNegocio clientesNegocio = new ClientesNegocio();
        List<Clientes> listaClientes = new List<Clientes>();
        private frmPrincipal frmPrincipal;
        public int indexUltimo { get; set; }

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
            listaClientes = clientesNegocio.listar();
            dgvGrillaClientes.DataSource = listaClientes;

            txtFiltroRapido.PlaceholderText = "Filtrar por Nombre, Apellido o Teléfono.";
            txtFiltroId.PlaceholderText = "Filtrar solo por Numero de Cliente";
            indexUltimo = -1;
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroRapido.Text.ToLower();
            List<Clientes> listaFiltrada;
            if (filtro.Length > 0)
            {
                listaFiltrada = listaClientes.FindAll(x => x.Nombre.ToLower().Contains(filtro) || x.Id.ToString().Contains(filtro) || x.Apellido.ToLower().Contains(filtro) || x.Telefono.Contains(filtro));
                dgvGrillaClientes.DataSource = listaFiltrada;

            }
            else
                dgvGrillaClientes.DataSource = listaClientes;
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

        private void txtFiltroId_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroId.Text.ToLower();
            List<Clientes> listaFiltrada;
            if (filtro.Length > 0)
            {
                listaFiltrada = listaClientes.FindAll(x => x.Id.ToString().Contains(filtro));
                dgvGrillaClientes.DataSource = listaFiltrada;

            }
            else
                dgvGrillaClientes.DataSource = listaClientes;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFiltroId.Text = string.Empty;
            txtFiltroRapido.Text = string.Empty;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

        }

        private void dgvGrillaClientes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Clientes> listaOrdenada;


            if (e.ColumnIndex == 0)
            {
                listaOrdenada = listaClientes.OrderBy(x => x.Id).ToList();
                if (indexUltimo == 0)
                {
                    listaOrdenada = listaClientes.OrderByDescending(x => x.Id).ToList();
                    indexUltimo = -1;
                }
                else
                    indexUltimo = 0;
                dgvGrillaClientes.DataSource = listaOrdenada;
            }
            if (e.ColumnIndex == 1)
            {
                listaOrdenada = listaClientes.OrderBy(x => x.Nombre).ToList();
                if (indexUltimo == 0)
                {
                    listaOrdenada = listaClientes.OrderByDescending(x => x.Nombre).ToList();
                    indexUltimo = -1;
                }
                else
                    indexUltimo = 0;
                dgvGrillaClientes.DataSource = listaOrdenada;
            }
            if (e.ColumnIndex == 2)
            {
                listaOrdenada = listaClientes.OrderBy(x => x.Apellido).ToList();
                if (indexUltimo == 0)
                {
                    listaOrdenada = listaClientes.OrderByDescending(x => x.Apellido).ToList();
                    indexUltimo = -1;
                }
                else
                    indexUltimo = 0;
                dgvGrillaClientes.DataSource = listaOrdenada;
            }
            if (e.ColumnIndex == 5)
            {
                listaOrdenada = listaClientes.OrderBy(x => x.Cumple).ToList();
                if (indexUltimo == 0)
                {
                    listaOrdenada = listaClientes.OrderByDescending(x => x.Cumple).ToList();
                    indexUltimo = -1;
                }
                else
                    indexUltimo = 0;
                dgvGrillaClientes.DataSource = listaOrdenada;
            }
            if (e.ColumnIndex == 6)
            {
                listaOrdenada = listaClientes.OrderBy(x => x.UltVisita).ToList();
                if (indexUltimo == 0)
                {
                    listaOrdenada = listaClientes.OrderByDescending(x => x.UltVisita).ToList();
                    indexUltimo = -1;
                }
                else
                    indexUltimo = 0;
                dgvGrillaClientes.DataSource = listaOrdenada;
            }


        }

        private void dgvGrillaClientes_MouseHover(object sender, EventArgs e)
        {

            lblInfo.Text = "Presiona sobre las cabeceras de los campos con \"*\" para ordenarlos.";
            Timer timer = new Timer();
            timer.Interval = 5000; // Establece el intervalo a 5000 ms (5 segundos)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty; // Borra el texto del Label
            ((Timer)sender).Stop(); // Detiene el temporizador después de borrar el texto
        }
    }
}

