﻿using Dominio;
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
    public partial class frmNuevaVenta : Form
    {
        private frmPrincipal FrmPrincipal;
        private Clientes cliente;
        public frmNuevaVenta(Clientes cliente, frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this.FrmPrincipal = frmPrincipal;
            this.cliente = cliente;
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
