using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Service
{
    public class PersonajeService
    {
       

        public List<PersonajeFF> Listar(string query)
        {
            List<PersonajeFF> listaPers = new List<PersonajeFF>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetConsulta(query);
                datos.EjecutarLectura();
                

                while (datos.Lector.Read())
                {
                    PersonajeFF aux = new PersonajeFF();
                    aux.IdPers = (int)datos.Lector["id_pers"];
                    aux.Nombre = (string)datos.Lector["nombre_pers"];
                    aux.Descripcion = (string)datos.Lector["descripcion_pers"];
                    aux.UrlImagen = (string)datos.Lector["imagen_pers"];
                    listaPers.Add(aux);
                
                }
                return listaPers;
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
         

        public void AgregarPersonaje(PersonajeFF nuevo, int value)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("insert into personajes (nombre_pers, descripcion_pers, imagen_pers, numero_juegos, activo) values ( @nombre_pers , '" + nuevo.Descripcion + "', '" + nuevo.UrlImagen + "', " + value + ", 1)");
                datos.SetParametro("@nombre_pers", nuevo.Nombre);   // Otra manera de insertar valor en consulta, ademas de concatenar
                datos.EjecutarAccion();
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

        public void EliminarPersonaje(PersonajeFF borrado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("delete from personajes where id_pers = @id");
                datos.SetParametro("@id", borrado.IdPers);
                datos.EjecutarAccion();
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

        public void EliminarTemporal(PersonajeFF borrado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("update personajes set activo = 0 where id_pers = @id");
                datos.SetParametro("@id", borrado.IdPers);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPersonaje(PersonajeFF modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("update personajes set nombre_pers = @nombre, descripcion_pers = @descripcion, imagen_pers = @imagen where id_pers = @id");
                datos.SetParametro("@nombre", modificado.Nombre);
                datos.SetParametro("@descripcion", modificado.Descripcion);
                datos.SetParametro("@imagen", modificado.UrlImagen);
                datos.SetParametro("@id", modificado.IdPers);
                datos.EjecutarAccion();
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
