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
    public partial class frmCaja : Form
    {
        frmPrincipal form;
        public frmCaja(frmPrincipal form)
        {
            InitializeComponent();
            this.form = form;
        }

    }
}
