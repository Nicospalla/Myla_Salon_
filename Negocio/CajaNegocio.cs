using Accesorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CajaNegocio
    {
        public bool cajaActiva(DateTime fecha)
        {
            AccesoDatos datos = new();
            bool status = false;
            try
            {
                datos.setearConsulta("Select Estado from CAJA where Fecha = @fecha");
                datos.setearParametros("@fecha", fecha);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    if (datos.Lector["Estado"].ToString() == "1")
                    {
                        status = true;
                    }
                }
                return status;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
