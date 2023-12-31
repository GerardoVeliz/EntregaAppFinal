﻿using System;
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
        public void bajaFisica( int id)
        {
            accesoDatos datos = new accesoDatos(); 
            
            try
            {
                datos.SetearQuery("delete from ARTICULOS where Id = @id");
                datos.setearParametros("@id", id);
                datos.ejecutarAccion(); 
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

        public void agregarAuto(Auto nuevo)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                //datos.SetearQuery("insert into POKEMONS(Numero, Nombre, Descripcion, Activo, idTipo, idDebilidad,UrlImagen) values("+nuevo.IdPokemon+", '"+nuevo.nombre+"', '"+nuevo.descripcion+ "', 1, @idTipo, @idDebilidad,@UrlImagen)");
                datos.SetearQuery("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,Precio,ImagenUrl) values ('"+nuevo.codigo+"','"+nuevo.nombre+"','"+nuevo.descripcion+"',@IdMarca,@IdCategoria,"+nuevo.precio+",'"+nuevo.urlImagen+"')");
                datos.setearParametros("@IdMarca", nuevo.marca.id);
                datos.setearParametros("@IdCategoria", nuevo.categoria.id);
                datos.ejecutarAccion();

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
                    if (!(datos.lector["UrlImagen"] is DBNull))
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

        public void modificarAuto(Auto auto)
        {
                accesoDatos datos = new accesoDatos(); 
            try
            {
                datos.SetearQuery("update ARTICULOS set codigo =@codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca =@idMarca, IdCategoria =@idCategoria , precio = @precio, ImagenUrl = @imagenUrl where Id = @id");
                datos.setearParametros("@codigo",auto.codigo);
                datos.setearParametros("@nombre",auto.nombre);
                datos.setearParametros("@descripcion",auto.descripcion);
                datos.setearParametros("@idMarca",auto.marca.id);
                datos.setearParametros("@idCategoria",auto.categoria.id);
                datos.setearParametros("@precio",auto.precio);
                datos.setearParametros("@imagenUrl",auto.urlImagen);
                datos.setearParametros("@id",auto.Id);

                datos.ejecutarAccion();
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

        public List<Auto> filtrar(string campo, string criterio, string filtro)
        {
            accesoDatos accesoDatos = new accesoDatos();
            List<Auto> autos = new List<Auto>();
            string consulta = "select a.Id,a.Codigo,a.Nombre,a.Descripcion,a.ImagenUrl UrlImagen,c.Descripcion Tipo,m.Descripcion Marca,a.Precio,a.IdCategoria,a.IdMarca from ARTICULOS a ,CATEGORIAS c, MARCAS m where c.Id=a.IdCategoria and m.Id=a.IdMarca and ";
            try
            {
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio >" + filtro; 
                            break;
                        case "Menor a":
                            consulta += "Precio <" + filtro;
                            break;
                        case "Igual a":
                            consulta += "Precio =" + filtro;
                            break; 
                    }

                } else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "a.Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "a.Nombre like '%" + filtro + "%'";
                            break;

                    }
                }
                else if (campo == "Descripcion")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "a.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "a.Descripcion like '%" + filtro + "%'";
                            break;

                    }
                }
                else if (campo == "Codigo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "a.Codigo like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "a.Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "a.Codigo like '%" + filtro + "%'";
                            break;

                    }
                }
                accesoDatos.SetearQuery(consulta);
                accesoDatos.ejecutarLectura();
                while (accesoDatos.lector.Read())
                {
                    Auto aux = new Auto();
                    aux.Id = (int)accesoDatos.lector["Id"];
                    aux.codigo = (string)accesoDatos.lector["Codigo"];
                    aux.nombre = (string)accesoDatos.lector["Nombre"];
                    aux.descripcion = (string)accesoDatos.lector["Descripcion"];
                    aux.precio = (decimal)accesoDatos.lector["Precio"];
                    if (!(accesoDatos.lector["UrlImagen"] is DBNull))
                        aux.urlImagen = (string)accesoDatos.lector["UrlImagen"];
                    aux.marca = new Marca();
                    aux.marca.id = (int)accesoDatos.lector["IdMarca"];
                    aux.marca.descripcion = (string)accesoDatos.lector["Marca"];
                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)accesoDatos.lector["IdCategoria"];
                    aux.categoria.descripcion = (string)accesoDatos.lector["Tipo"];

                    autos.Add(aux);

                }

                return autos; 

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
