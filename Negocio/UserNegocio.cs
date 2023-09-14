using Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.Identity.Client;

namespace Negocio
{
    public class UserNegocio
    {

        public User getUser(string usuario, string password)
        {
            AccesoDatos datos = new AccesoDatos();
            User aux = new User();
            try
            {
                datos.setearConsulta("Select Id, Admin FROM LOGIN where Usuario = @usuario and Password = @Password");
                datos.setearParametros("@usuario", usuario);
                datos.setearParametros("@password", password);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Usuario = usuario;
                    aux.Password = password;
                    aux.Admin = (bool)datos.Lector["Admin"];
                }

            return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }

        }
        public List<User> listarUser(User user)
        {
            AccesoDatos datos = new();
            List<User> lista = new();
            try
            {
                datos.setearConsulta("  Select Id , Usuario, Password, Admin FROM LOGIN where Id != @Id");
                datos.setearParametros("@Id", user.Id);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    User aux =new User();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Usuario = (string)datos.Lector["Usuario"];
                    aux.Password = (string)datos.Lector["Password"];
                    aux.Admin = (bool)datos.Lector["Admin"];
                    lista.Add(aux);
                }

                return lista;
            }

            catch (Exception ex)
            {

                throw ex;
            }finally { datos.cerrarConn(); }
        }

        public void nuevoUser(User user)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("Insert into LOGIN (Usuario, Password, Admin) values (@Usuario, @Password, @Admin)");
                datos.setearParametros("@Usuario", user.Usuario);
                datos.setearParametros("@Password", user.Password);
                datos.setearParametros("@Admin", user.Admin);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }

        }
        public void editarUSer(User user)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("UPDATE LOGIN set Usuario = @Usuario, Password = @Password, Admin = @Admin where Id = @UserId");
                datos.setearParametros("@Usuario", user.Usuario);
                datos.setearParametros("@Password", user.Password);
                datos.setearParametros("@Admin", user.Admin);
                datos.setearParametros("@UserId", user.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConn(); }
        }
        public void eliminaUser(User user)
        {
            AccesoDatos datos = new();
            try
            {
                datos.setearConsulta("DELETE FROM LOGIN where Id = @UserId");
                datos.setearParametros("@UserId", user.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
