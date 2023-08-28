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
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio subCategoriaNegocio = new SubCategoriaNegocio();
        frmPrincipal frmPrincipal;
        public frmEspecialistas(frmPrincipal frmPrincipal,Especialista? esp = null)
        {
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
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

        }

        private void cargaDGVS(int idEsp)
        {
            //List<Categorias> lista1 = categoriaNegocio.listarCat(esp.IdEspecialista, false);
            //List<int> listInt = new List<int>();
            //for(int i = 0; i < lista1.Count; i++)
            //{
            //    Categorias aux = lista1[i];
            //    listInt.Add(aux.idCat); 
            //}
            dgvCat.DataSource = categoriaNegocio.listarCat(esp.IdEspecialista, false);
            dgvCat.Columns["IdCat"].Visible = false;
            dgvNoCat.DataSource = categoriaNegocio.listarCat(esp.IdEspecialista, true);
            dgvNoCat.Columns["IdCat"].Visible = false;
            dgvNoSubCat.DataSource = subCategoriaNegocio.listarSubCat(0,idEsp,false);
            dgvNoSubCat.Columns["IdSub"].Visible = false;
            dgvNoSubCat.Columns["IdCategoria"].Visible = false;
            
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
                cargaDGVS(esp.IdEspecialista);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal.verGrilla();
        }
    }
}
