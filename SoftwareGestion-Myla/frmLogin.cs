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
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using User = Dominio.User;

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
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server"))
            {
                return key != null;
            }
        }

        private void bloqueoAccion()
        {
            btnIngresar.Enabled = false;
            txtPass.Enabled = false;
            txtUser.Enabled = false;
        }
        
        private void mensajeHiper()
        {
            var custom = new frmError();
            custom.ShowDialog();
        }
        private async void frmLogin_Load(object sender, EventArgs e)
        {
            if (SQLInstalado())
            {

                // Parámetros de línea de comandos para la instalación de SQL Server

                //MessageBox.Show("Debe instalar SQL Server 2019 antes de utilizar la aplicación.\nPuede hacerlo desde: ");
                mensajeHiper();
                bloqueoAccion();
                return;
            }

            AccesoDatos datosCreation = new AccesoDatos(1);
            bool existeDDBB = true;
            try
            {
                datosCreation.setearConsulta("SELECT COUNT(*) FROM sys.databases WHERE name = 'MYLA_DBB'");
                existeDDBB = datosCreation.verificarExisteciaDDBB();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datosCreation.cerrarConn(); }


            if (!existeDDBB)
            {
                string dirActual = AppDomain.CurrentDomain.BaseDirectory;
                string rutaDDBB = Path.Combine(dirActual, "BBDD\\MYLA_DB.sql");
                if (File.Exists(rutaDDBB))
                {
                    MessageBox.Show("Existe el archivo");
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

                        if (ejecutar.ExitCode != 0)
                        {
                            MessageBox.Show("Error al ejecutar el script SQL, contacte a su desarrollador.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            bloqueoAccion();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    MessageBox.Show("No existe el archivo de Instalacion de la  DDBB.\n Contáctese con el desarrollador.");
                }
            }

            if (SQLInstalado() && DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                Helpers help = new();
                help.creakBackUp();
            }

        }
    }
}
