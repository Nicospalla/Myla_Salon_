using Accesorios;
using Dominio;
using Microsoft.Data.SqlClient;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace SoftwareGestion_Myla
{
    public partial class frmLogin : Form
    {
        CajaNegocio cajaNegocio = new();
        public frmLogin()
        {

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UserNegocio userNegocio = new UserNegocio();
            User aux;
            try
            {
                aux = userNegocio.getUser(txtUser.Text, txtPass.Text);
                if (aux.Id != 0)
                {
                    if (cajaNegocio.cajaActiva(DateTime.Today) == false)
                    {
                        frmPopUp popUp = new frmPopUp(aux);
                        popUp.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        frmPrincipal frmPrincipal = new frmPrincipal(aux);
                        frmPrincipal.Show();
                        this.Hide();

                    }

                }
                else
                    lblError.Text = "Datos incorrectos o usuario inexistente.";



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static bool SQLInstalado()
        {
            using(RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
            {
                return key != null;
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            if(!SQLInstalado() )
            {
                MessageBox.Show("Debe instalar SQL Server 2019 antes de utilizar la aplicación.");
                btnIngresar.Enabled = false;
                return;
            }
            AccesoDatos datos = new();
            bool existeDDBB;
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM sys.databases WHERE name = 'MYLA_DB'");
                existeDDBB = datos.verificarExisteciaDDBB();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }


            if (!existeDDBB)
            {
                string dirActual = AppDomain.CurrentDomain.BaseDirectory;
                string rutaDDBB = Path.Combine(dirActual, "BBDD\\MYLA_DB.sql");
                if (File.Exists(rutaDDBB))
                {
                    try
                    {
                        string script = File.ReadAllText(rutaDDBB);
                        ProcessStartInfo info = new ProcessStartInfo("sqlcmd", $"-S .\\SQLEXPRESS -i \"{rutaDDBB}\"");
                        info.UseShellExecute = false;
                        info.CreateNoWindow = true;
                        info.RedirectStandardOutput = true;
                        Process ejecutar = new Process();
                        ejecutar.StartInfo = info;
                        ejecutar.Start();

                        ejecutar.WaitForExit();

                        if (ejecutar.ExitCode == 0)
                        {
                            Console.WriteLine("Script SQL ejecutado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Error al ejecutar el script SQL.");
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
