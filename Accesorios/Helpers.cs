using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Accesorios
{
    public class Helpers
    {
        public string aMayus(string texto)
        {
            texto = texto.ToLower();
            texto = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(texto);
            return texto;
        }

        public bool soloNum(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {

                texto = texto.Replace(",", ".");
                char[] chars = texto.ToCharArray();
                int contador = 0;
                foreach (char s in chars)
                {
                    if (s == '.')
                    {
                        if (contador >= 1)
                            return false;
                        contador++;
                    }
                    else if (s != '.' && contador <= 1 && char.IsDigit(s))
                    {
                        continue;
                    }
                    else { return false; }

                }
            }
            return true;

        }
        public bool validEmail(string mail)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (Regex.IsMatch(mail, pattern))
                return true;

            return false;
        }

        public void creakBackUp(string path = "")
        {
            AccesoDatos datos = new();
            AccesoDatos datos2 = new();
            AccesoDatos datos3 = new();
            string date = DateTime.Today.ToString("dd-MM-yy");
            try
            {
                string dirActual = AppDomain.CurrentDomain.BaseDirectory;
                string rutaDDBB = Path.Combine(dirActual, $"BBDD\\MylaBackUp-{date}.bak");

                //Eliminar los .bak si hay mas de 10
                int maximo = 2;
                DirectoryInfo directorio = new DirectoryInfo(Path.Combine(dirActual, "BBDD"));
                if(directorio.Exists)
                {
                    FileInfo[] archivos = directorio.GetFiles("*.bak");
                    var archivosOrdenados = archivos.OrderBy(f => f.CreationTimeUtc);

                    foreach (var archivo in archivosOrdenados)
                    {
                        if (archivos.Length >= maximo)
                        {
                            archivo.Delete();
                        }

                    }
                }


                //Genera los querys para la creacion del nuevo BackUp
                datos.setearConsulta($"USE master; ALTER DATABASE MYLA_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;");
                datos.ejecutarAccion();
                datos.cerrarConn();
                datos2.setearConsulta($"backup database MYLA_DB to disk ='{rutaDDBB}'");
                datos2.ejecutarAccion();
                datos2.cerrarConn();
                datos3.setearConsulta(" ALTER DATABASE MYLA_DB SET MULTI_USER");
                datos3.ejecutarAccion();
                datos3.cerrarConn();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        //public void enviarBackUp()
        //{
        //    AccesoDatos datos = new();
        //    string mail;
        //    EmailServices services = new EmailServices();
        //    try
        //    {
        //        string dirActual = AppDomain.CurrentDomain.BaseDirectory;
        //        string rutaBAK = Path.Combine(dirActual, "BBDD\\MylaBackUp.bak");
        //        string rutaMail = Path.Combine(dirActual, "BBDD\\mailBackUp.txt");
        //        if(File.Exists(rutaBAK))
        //        {
        //            StreamReader sr = new StreamReader(rutaMail);
        //            mail = sr.ReadToEnd();
        //            sr.Close();

        //            DateTime dia = DateTime.Today;
        //            services.armarCorreo(mail, $"BackUp{dia}",rutaBAK);
        //            services.enviarMail();

        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
        public void restaurarBBDD()
        {
            AccesoDatos datos = new();
            try
            {
                string dirActual = AppDomain.CurrentDomain.BaseDirectory;
                string rutaDDBB = Path.Combine(dirActual, "BBDD\\MylaBackUp.bak");

                datos.setearConsulta($"USE master; ALTER DATABASE MYLA_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE MYLA_DB from DISK='{rutaDDBB}' WITH REPLACE, RECOVERY ALTER DATABASE MYLA_DB SET MULTI_USER;");
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
    }
}
