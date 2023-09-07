using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGestion_Myla
{
    public partial class frmCategorias : Form
    {
        CategoriaNegocio categoriaNegocio = new();
        SubCategoriaNegocio subCategoriaNegocio = new();
        List<Categorias> listaCat;
        List<SubCategoria> listaSubCat;
        SubCategoria subAux;
        List<string> listaHoras;
        bool nuevoSub = false;

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargaCboHorario();
            cargaCategorias();
            cargaSubCategorias();

            btnNuevaCat.Enabled = false;

        }
        private void cargaCategorias()
        {
            listaCat = categoriaNegocio.listarCat();
            dgvCat.DataSource = listaCat;
            dgvCat.Columns["idCat"].Visible = false;
        }
        private void cargaSubCategorias()
        {
            if (dgvCat.CurrentRow != null)
            {
                int idCat = ((Categorias)dgvCat.CurrentRow.DataBoundItem).idCat;
                listaSubCat = subCategoriaNegocio.listarSubCat(0, idCat);
                dgvSubCat.DataSource = listaSubCat;
                dgvSubCat.Columns["IdSub"].Visible = false;
                dgvSubCat.Columns["idCategoria"].Visible = false;
            }
        }
        private void cargaCboHorario()
        {
            TimeSpan horaInicio = TimeSpan.FromHours(00);
            TimeSpan horaFin = TimeSpan.FromHours(12);
            TimeSpan intervalo = TimeSpan.FromMinutes(15);
            listaHoras = new();

            while (horaInicio < horaFin)
            {
                string hora = horaInicio.ToString(@"hh\:mm");
                listaHoras.Add(hora);
                horaInicio = horaInicio.Add(intervalo);
            }
            cboHorarios.DataSource = listaHoras;
        }
        private string aMayus(string texto)
        {
            texto = texto.ToLower();
            texto = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(texto);
            return texto;
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoria.Text.Length > 0)
                btnNuevaCat.Enabled = true;
            else
                btnNuevaCat.Enabled = false;

        }


        private void btnNuevaCat_Click(object sender, EventArgs e)
        {
            string nuevaCat = aMayus(txtCategoria.Text);
            try
            {
                categoriaNegocio.nuevaCat(nuevaCat);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            txtCategoria.Text = string.Empty;
            cargaCategorias();

        }

        private void btnModifCat_Click(object sender, EventArgs e)
        {
            dgvCat.Focus();
            if (dgvCat.CurrentRow != null)
            {
                Categorias aux = (Categorias)dgvCat.CurrentRow.DataBoundItem;
            }

        }

        private void btnAgregarSub_Click(object sender, EventArgs e)
        {
            nuevoSub = true;
            lblSubCatTitle.Text = "NUEVA SubCategoría";
            txtSubCat.Text = string.Empty;
            cboHorarios.SelectedIndex = 0;
        }

        private void dgvCat_SelectionChanged(object sender, EventArgs e)
        {
            cargaSubCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nuevoSub == true)
            {
                if (cboHorarios.SelectedItem.ToString().Contains("00:00"))
                {
                    lblErrorDuracion.Text = "Debe seleccionar una duración de trabajo";
                    return;
                }
                else
                {
                    lblErrorDuracion.Text = string.Empty;

                }
                SubCategoria aux = new() { idCategoria = ((Categorias)dgvCat.CurrentRow.DataBoundItem).idCat, Descripcion = aMayus(txtSubCat.Text), Duracion = TimeSpan.Parse(cboHorarios.SelectedItem.ToString()) };
                subCategoriaNegocio.nuevaSubCat(aux);
            }
            else if (nuevoSub == false)
            {
                lblSubCat.Text = "Editar SubCategoría:";
                subAux.Duracion = TimeSpan.Parse(cboHorarios.SelectedItem.ToString());
                subAux.Descripcion = aMayus(txtSubCat.Text);
                subCategoriaNegocio.editarSubCat(subAux);
            }
            cargaSubCategorias();
            lblSubCatTitle.Text = "EDITAR";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtSubCat.Text = string.Empty;
            cboHorarios.SelectedIndex = 0;
        }

        private void dgvSubCat_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubCat.CurrentRow != null)
            {
                nuevoSub = false;
                lblSubCatTitle.Text = "EDITAR";
                subAux = (SubCategoria)dgvSubCat.CurrentRow.DataBoundItem;
                pnlSubCat.Visible = true;
                txtSubCat.Text = subAux.Descripcion;
                for (int i = 0; i < listaHoras.Count; i++)
                {
                    if (listaHoras[i].Contains(subAux.Duracion.ToString(@"hh\:mm")))
                    {
                        cboHorarios.SelectedIndex = i;
                    }
                }
            }
        }

        private void btnEliminaSub_Click(object sender, EventArgs e)
        {
            dgvSubCat.Focus();
            if (dgvSubCat.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seguro desea eliminar la SubCategoría?", "Eliminar", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    subCategoriaNegocio.eliminarSubCat((SubCategoria)dgvSubCat.CurrentRow.DataBoundItem);
                }
                cargaSubCategorias();
            }
        }

        private void btnElimiCat_Click(object sender, EventArgs e)
        {
            dgvCat.Focus();
            if (dgvCat.CurrentRow != null)
            {
                DialogResult result = MessageBox.Show("Seguro desea eliminar la Categoría?", "Eliminar", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    categoriaNegocio.eliminarCat((Categorias)dgvCat.CurrentRow.DataBoundItem);
                }
            }
            cargaCategorias();
        }

        private void dgvSubCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
