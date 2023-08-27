using Dominio;
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
        public Especialista esp { get; set; }
        public frmEspecialistas(Especialista esp)
        {
            InitializeComponent();
            this.esp = esp;
        }

        private void frmEspecialistas_Load(object sender, EventArgs e)
        {

        }
    }
}
