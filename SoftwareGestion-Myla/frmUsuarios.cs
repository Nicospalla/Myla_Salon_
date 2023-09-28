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
using Dominio;
using System.Runtime.Intrinsics.X86;
using Accesorios;

namespace SoftwareGestion_Myla
{
    public partial class frmUsuarios : Form
    {
        frmPrincipal form;
        UserNegocio userNegocio = new();
        Helpers help = new();
        string filePath;
        public User aux { get; set; }
        public frmUsuarios(frmPrincipal form)
        {
            InitializeComponent();
            this.form = form;
            lblErrorPass.Text = string.Empty;
            lblErrorUser.Text = string.Empty;


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            form.nuevoTurno();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            recargaGrid();
            rbNO.Checked = true;
        }
        public void recargaGrid()
        {
            dgvUser.DataSource = userNegocio.listarUser(form.user);

        }
        private bool camposVacios()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                lblErrorUser.Text = "Debe escribir un Usuario";
                status = false;
            }
            else
                lblErrorUser.Text = string.Empty;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorPass.Text = "Debe escribir un Password";
                status = false;
            }
            else
                lblErrorPass.Text = string.Empty;
            if (!status)
                return false;
            else
                return true;
        }

        private void lblNuevo_Click(object sender, EventArgs e)
        {

            if (!camposVacios())
                return;
            User aux = new();
            aux.Usuario = txtUsuario.Text.ToLower();
            aux.Password = txtPassword.Text;
            if (rbSI.Checked)
                aux.Admin = true;
            else
                aux.Admin = false;
            userNegocio.nuevoUser(aux);
            limpiaCampos();
            recargaGrid();
        }
        private void limpiaCampos()
        {
            txtPassword.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            rbSI.Enabled = true;
            rbNO.Enabled = true;
            rbNO.Checked = true;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvUser.Focus();
            limpiaCampos();
            btnGuardar.Visible = Visible;
            if (dgvUser.CurrentRow != null)
            {
                this.aux = (User)dgvUser.CurrentRow.DataBoundItem;
                txtPassword.Text = aux.Password;
                txtUsuario.Text = aux.Usuario.ToLower();
                if (aux.Admin == true)
                    rbSI.Checked = true;
                else
                    rbNO.Checked = true;

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Seguro desea eliminar el Usuario?", "Elimina Usuario", MessageBoxButtons.OKCancel);
            if (resul == DialogResult.Cancel)
                return;
            dgvUser.Focus();
            if (dgvUser.CurrentRow != null)
            {
                User user = (User)dgvUser.CurrentRow.DataBoundItem;
                userNegocio.eliminaUser(user);
            }
            limpiaCampos();
            recargaGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!camposVacios())
                return;
            User aux = this.aux;
            aux.Usuario = txtUsuario.Text.ToLower();
            aux.Password = txtPassword.Text;
            if (rbNO.Enabled == true)
            {
                if (rbSI.Checked)
                    aux.Admin = true;
                else
                    aux.Admin = false;
            }
            else
                aux.Admin = true;
            userNegocio.editarUSer(aux);
            recargaGrid();
            limpiaCampos();
            btnGuardar.Visible = false;
        }

        private void btnEditarActivo_Click(object sender, EventArgs e)
        {

            aux = form.user;
            btnGuardar.Visible = Visible;
            txtPassword.Text = aux.Password;
            txtUsuario.Text = aux.Usuario.ToLower();
            if (aux.Admin == true)
            {
                rbSI.Checked = true;
            }
            else
            {
                rbNO.Checked = true;
            }
            rbNO.Enabled = false;
            rbSI.Enabled = false;

        }


        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea generar un nuevo BackUp?", "Nuevo BackUp", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                help.creakBackUp();
            }

        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea restaurar la BBDD?\nEsta acción es irreversible!", "Restaurar BBDD", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                result = MessageBox.Show("Lo siento, pero debemos repetir el consetimiento.\nEstá seguro de restaurar la BBDD?", "Restaurar BBDD", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        if(filePath != null)
                        {
                            help.restaurarBBDD(filePath);
                            form.nuevoTurno();

                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

        }

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            FileDialog file = new OpenFileDialog();
            string dirActual = AppDomain.CurrentDomain.BaseDirectory;
            string rutaDDBB = Path.Combine(dirActual, "BBDD");

            file.Title = "Seleccionar BackUp";
            file.Filter = "Copia de seguridad (*.bak)|*.bak";
            file.InitialDirectory = rutaDDBB;

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = string.Empty;
                filePath = file.FileName;
                txtFile.Text = filePath;
            }

        }
    }
}
