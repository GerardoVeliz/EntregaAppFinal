using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class categoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.SetearQuery("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.id = (int)datos.lector["Id"];
                    aux.descripcion = (string)datos.lector["Descripcion"];
                    categorias.Add(aux);

                }

                return categorias;
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
