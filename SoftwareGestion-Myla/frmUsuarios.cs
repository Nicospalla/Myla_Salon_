﻿using Negocio;
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

namespace SoftwareGestion_Myla
{
    public partial class frmUsuarios : Form
    {
        frmPrincipal form;
        UserNegocio userNegocio = new();
        public User aux { get; set; }
        public frmUsuarios(frmPrincipal form)
        {
            InitializeComponent();
            this.form = form;


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

        private void lblNuevo_Click(object sender, EventArgs e)
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
            rbNO.Enabled = false;
            rbSI.Enabled = false;
            
        }
    }
}
