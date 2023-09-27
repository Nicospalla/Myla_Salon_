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
    public partial class frmError : Form
    {
        public frmError()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer", "https://www.microsoft.com/es-es/sql-server/sql-server-downloads");
            }
            catch (Exception exx)
            {

                throw exx;
            }
        }

        private void frmError_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
