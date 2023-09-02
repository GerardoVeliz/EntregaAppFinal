using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
     public class autoNegocio
    {
        public List <Auto> listarAutos()
        {
            List<Auto> autos = new List<Auto>();
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.SetearQuery("select a.Id,a.Codigo,a.Nombre,a.Descripcion,a.ImagenUrl UrlImagen,c.Descripcion Tipo,m.Descripcion Marca,a.Precio,a.IdCategoria,a.IdMarca from ARTICULOS a ,CATEGORIAS c, MARCAS m where c.Id=a.IdCategoria and m.Id=a.IdMarca");
                datos.ejecutarLectura();
                while (datos.lector.Read())
                {
                    Auto aux = new Auto();
                    aux.Id = (int)datos.lector["Id"];
                    aux.codigo = (string)datos.lector["Codigo"];
                    aux.nombre= (string)datos.lector["Nombre"];
                    aux.descripcion= (string)datos.lector["Descripcion"];
                    aux.precio = (decimal)datos.lector["Precio"];
                    //if (!(datos.lector["UrlImagen"] is DBNull))
                    
                    aux.urlImagen= (string)datos.lector["UrlImagen"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.lector["Tipo"];

                    autos.Add(aux);
                    
                }
                return autos;
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
