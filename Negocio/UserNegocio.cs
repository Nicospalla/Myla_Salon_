using Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UserNegocio
    {
        AccesoDatos datos = new AccesoDatos();

        public User getUser(string usuario, string password)
        {
            User aux = new User();
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
    }
}
