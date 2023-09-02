using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class marcaNegocio
    {
        public List<Marca> listarMarcas()
        {
        List<Marca> marcas = new List<Marca>();
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.SetearQuery("select Id,Descripcion from MARCAS ");
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = (int)datos.lector["Id"];
                    aux.descripcion = (string)datos.lector["Descripcion"];
                    marcas.Add(aux);
                }
                return marcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }
        
    }
}
