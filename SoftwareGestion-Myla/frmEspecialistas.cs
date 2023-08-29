﻿using Dominio;
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
        public List<int> listaCat { get; set; }
        public int indexPrev { get; set; }
        public frmEspecialistas(frmPrincipal frmPrincipal, Especialista? esp = null)
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
            int selected = esp != null ? esp.IdEspecialista : 1;
            cboEsp.DisplayMember = "Nombre";
            cboEsp.SelectedValue = selected;
            txtSueldo.PlaceholderText = "Solo ingrese Numeros";
            txtPorcentaje.PlaceholderText = "Solo ingrese Numeros";
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

            //dgvCat.DataSource = categoriaNegocio.listarCat(esp.IdEspecialista, true);
            List<Categorias> listaDgvCat = categoriaNegocio.listarCat(esp.IdEspecialista, true);
            dgvCat.DataSource = listaDgvCat;
            listaCat = new List<int>();
            for (int i = 0; i < listaDgvCat.Count; i++)
            {
                int idCat = ((Categorias)listaDgvCat[i]).idCat;
                listaCat.Add(idCat);
            }
            dgvCat.Columns["IdCat"].Visible = false;
            dgvNoCat.DataSource = categoriaNegocio.listarCat(esp.IdEspecialista, false);
            dgvNoCat.Columns["IdCat"].Visible = false;


        }

        private void cboEsp_SelectedIndexChanged(object sender, EventArgs e)
        {

            string a = cboEsp.SelectedValue.ToString();
            int numero;
            if (cboEsp.SelectedIndex != -1 && int.TryParse(a, out numero))
            {
                if (esp == null)
                    esp = new Especialista();

                esp.IdEspecialista = (int)cboEsp.SelectedValue;
                int id = esp.IdEspecialista;
                List<Especialista> listaUnica = especialistaNegocio.listaEspecialista(esp.IdEspecialista);
                esp = listaUnica[0];
                txtId.Text = esp.IdEspecialista.ToString();
                txtEmail.Text = esp.Email;
                txtApellido.Text = esp.Apellido;
                txtSueldo.Text = esp.Sueldo.ToString();
                txtPorcentaje.Text = esp.Porcentaje.ToString(); 
                dateCumple.Value = esp.Cumple;
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

        private void btnAgregaCat_Click(object sender, EventArgs e)
        {
            dgvNoCat.Focus();
            if (dgvNoCat.CurrentRow != null)
            {
                Categorias aux = (Categorias)dgvNoCat.CurrentRow.DataBoundItem;
                categoriaNegocio.insertarCategoria(esp.IdEspecialista, aux.idCat);
                frmPrincipal.editarEsp(esp);

            }
        }

        private void btnQuitarCat_Click(object sender, EventArgs e)
        {
            dgvCat.Focus();
            if (dgvCat.CurrentRow != null)
            {
                Categorias aux = (Categorias)dgvCat.CurrentRow.DataBoundItem;
                categoriaNegocio.quitarCategoria(esp.IdEspecialista, aux.idCat);
                frmPrincipal.editarEsp(esp);
            }
        }

        private void btnModifEsp_Click(object sender, EventArgs e)
        {
            EspecialistaNegocio especialistaNegocio = new EspecialistaNegocio();
            try
            {
                Especialista aux = new Especialista();
                aux.Nombre = cboEsp.Text;
                aux.Apellido = txtApellido.Text;
                aux.IdEspecialista = int.Parse(txtId.Text);
                aux.Email = txtEmail.Text;
                aux.Telefono = txtTelefono.Text;
                aux.Cumple = dateCumple.Value; 
                if (txtSueldo.Text != "" && int.TryParse(txtSueldo.Text, out int val))
                    aux.Sueldo = int.Parse(txtSueldo.Text);
                if(txtPorcentaje.Text != "" && int.TryParse(txtPorcentaje.Text, out int valo))
                    aux.Porcentaje = int.Parse(txtPorcentaje.Text);
                especialistaNegocio.editarEspecialista(aux);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
