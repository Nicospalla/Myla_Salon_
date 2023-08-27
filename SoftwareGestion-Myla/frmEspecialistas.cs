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
    public partial class frmEspecialistas : Form
    {
        public Especialista? esp { get; set; }
        EspecialistaNegocio especialistaNegocio = new EspecialistaNegocio();
        //public frmEspecialistas()
        //{
        //    InitializeComponent();
        //}
        public frmEspecialistas(Especialista? esp = null)
        {
            InitializeComponent();
            if (esp != null)
            {
                this.esp = esp;
            }
        }

        private void frmEspecialistas_Load(object sender, EventArgs e)
        {
            cboEsp.DataSource = especialistaNegocio.listaEspecialista();
            cboEsp.ValueMember = "IdEspecialista";
            cboEsp.DisplayMember = "Nombre";
            if (esp != null)
            {
                cboEsp.SelectedValue = esp.IdEspecialista;
                txtId.Text = esp.IdEspecialista.ToString();
                txtApellido.Text = esp.Apellido;
                txtEmail.Text = esp.Email;

                //dateCumple.Value = esp.Cumple.Date;
            }
            else
            {
                cboEsp.SelectedIndex = -1;
            }
        }

        private void cboEsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cboEsp.SelectedValue.ToString();
            int numero;
            if (cboEsp.SelectedIndex != -1 && int.TryParse(a, out numero))
            {
                esp = new Especialista();
                esp.IdEspecialista = (int)cboEsp.SelectedValue;
                int id = esp.IdEspecialista;
                List<Especialista> listaUnica = especialistaNegocio.listaEspecialista(esp.IdEspecialista);
                esp = listaUnica[0];
                txtId.Text = esp.IdEspecialista.ToString();
                txtEmail.Text = esp.Email;
                txtApellido.Text = esp.Apellido;

                //Categorias cat = (Categorias)cboCategoria.SelectedValue;
                //int id = cat.idCat;
                //cboEspecialista.DataSource = Especialistas_Categorias_Negocio.listarEspCat(id);

            }
        }
    }
}
