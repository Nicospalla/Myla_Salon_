﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGestion_Myla
{
    public partial class frmNuevaVenta : Form
    {
        private frmPrincipal FrmPrincipal;
        private Clientes cliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        EspecialistaNegocio EspecialistaNegocio = new EspecialistaNegocio();
        Especialistas_Categorias_Negocio Especialistas_Categorias_Negocio = new Especialistas_Categorias_Negocio();
        HistoVentasNegocio ventasNegocio = new HistoVentasNegocio();
        public frmNuevaVenta(Clientes cliente, frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = frmPrincipal;
            this.cliente = cliente;
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            txtCliente.ReadOnly = true;
            txtCliente.Text = cliente.Nombre;
            cboEspecialista.DataSource = EspecialistaNegocio.listaEspecialista();
            cboEspecialista.DisplayMember = "Descripcion";
            cboEspecialista.SelectedIndex = -1;

        }

        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            //Aca carga la seccion de sub categorias, que depende del ESPECIALISTA (A su vez, tiene la
            //  - dependencia con las CAT)
            if (cboCategoria.SelectedIndex != -1)
            {
                Categorias auxCat = (Categorias)cboCategoria.SelectedValue;
                Especialista aux = (Especialista)cboEspecialista.SelectedValue;
                cboSubCat.DataSource = SubCategoriaNegocio.listarSubCat(aux.IdEspecialista, auxCat.idCat, true);
                cboSubCat.DisplayMember = "Descripcion";
                //cboSubCat.ValueMember = "IdSub";
                cboSubCat.SelectedIndex = -1;
            }
            else
            {

                cboSubCat.DataSource = null;
                cboSubCat.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea borrar los datos?", "Volver a grilla principal", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                FrmPrincipal.verGrilla();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool status = true;
            status = cboCategoria.SelectedIndex != -1 ? status : false;
            lblErrorCat.Text = cboCategoria.SelectedIndex == -1 ? "Debe seleccionar una Categoría" : "";
            status = cboEspecialista.SelectedIndex != -1 ? status : false;
            lblErrorEspe.Text = cboEspecialista.SelectedIndex == -1 ? "Debe seleccionar un Especialista" : "";
            if (status == false)
            {
                MessageBox.Show("Por favor revise los datos.", "Faltan datos", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Esta segura de guardar ésta nueva venta?", "Nueva venta", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    HistoVentas venta = new HistoVentas();

                    venta.IdCat = new Categorias();
                    Categorias cat = (Categorias)cboCategoria.SelectedValue;
                    venta.IdCat.idCat = cat.idCat;

                    venta.IdCliente = cliente.Id;

                    venta.Especialista = new Especialista();
                    //Especialista esp = (Especialista)cboEspecialista.SelectedValue;
                    venta.Especialista.IdEspecialista = ((Especialista)cboEspecialista.SelectedValue).IdEspecialista;
                    //venta.Especialista.IdEspecialista = (int)cboEspecialista.SelectedValue;

                    venta.CodigoTinte = txtCodigoTinte.Text;
                    venta.Precio = txtPrecio.Text != "" ? Math.Truncate(Decimal.Parse(txtPrecio.Text) * 100) / 100 : 0;
                    venta.Fecha = DateTime.Today;

                    venta.IdSub = new SubCategoria();
                    //SubCategoria sub = (SubCategoria)cboSubCat.SelectedValue;
                    venta.IdSub.IdSub = ((SubCategoria)cboSubCat.SelectedValue).IdSub;

                    venta.ServicioAdicional = txtServAdc.Text;
                    ventasNegocio.nuevaVenta(venta);
                    FrmPrincipal.muestraHistorial(cliente.Id);
                }
                else
                    return;

            }
        }

        private void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboEspecialista.SelectedIndex != -1)
            {
                Especialista aux = (Especialista)cboEspecialista.SelectedValue;
                cboCategoria.DataSource = categoriaNegocio.listarCat(aux.IdEspecialista, true);
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;

            }
            else
            {
                cboCategoria.DataSource = null;
                cboCategoria.SelectedIndex = -1;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal.verGrilla();
        }
    }
}


