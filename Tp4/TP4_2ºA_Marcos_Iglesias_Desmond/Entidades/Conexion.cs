using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Conexion
    {

        private static Ejecutar EjecutarSql;

        private static string stringConetion;
        private static SqlConnection miConexion;
        private static SqlCommand comando;

        static Conexion()
        {

            EjecutarSql = EjecutarQuery;
            stringConetion = @"Data Source= (local)\sqlexpress ; Initial Catalog =TP4_IglesiasMarcos ; Integrated Security=True";

            miConexion = new SqlConnection(stringConetion);
            comando = new SqlCommand();


            try
            {
                comando.Connection = miConexion;
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }

        }


        public List<Producto> ObtenerInventario()
        {
            List<Producto> listaProductos = new List<Producto>();

            Conexion.comando.CommandText = "Select Nombre,Codigo,Precio,Stock,Stock_SI_NO,ProductoCongelado,Tipo From Producto";

            try
            {
                Conexion.miConexion.Open();

                SqlDataReader sqlDataReader = Conexion.comando.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    if ((bool)sqlDataReader["ProductoCongelado"])
                    {

                        if (sqlDataReader["Tipo"].ToString().Equals("Carne"))
                        {
                            ProductoCongelado<ECarnes> productoCongelado = new ProductoCongelado<ECarnes>();

                            ECarnes categoria = productoCongelado.ParceCarne(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoCongelado<ECarnes>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);

                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Lacteo"))
                        {

                            ProductoCongelado<ELacteos> productoCongelado = new ProductoCongelado<ELacteos>();

                            ELacteos categoria = productoCongelado.ParceLacteo(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoCongelado<ELacteos>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }

                    }
                    else
                    {

                        if (sqlDataReader["Tipo"].ToString().Equals("Fruta"))
                        {
                            ProductoNoCongelado<EFrutas> productoCongelado = new ProductoNoCongelado<EFrutas>();

                            EFrutas categoria = productoCongelado.ParceFrutas(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<EFrutas>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);

                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Verdura"))
                        {
                            ProductoNoCongelado<EVerduras> productoCongelado = new ProductoNoCongelado<EVerduras>();

                            EVerduras categoria = productoCongelado.ParceVerduras(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<EVerduras>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Higiene"))
                        {
                            ProductoNoCongelado<EHigiene> productoCongelado = new ProductoNoCongelado<EHigiene>();

                            EHigiene categoria = productoCongelado.ParceHigiene(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<EHigiene>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Limpieza"))
                        {
                            ProductoNoCongelado<ELimpieza> productoCongelado = new ProductoNoCongelado<ELimpieza>();

                            ELimpieza categoria = productoCongelado.ParceLimpieza(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<ELimpieza>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Golozina"))
                        {
                            ProductoNoCongelado<EGolocinas> productoCongelado = new ProductoNoCongelado<EGolocinas>();

                            EGolocinas categoria = productoCongelado.ParceGolocinas(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<EGolocinas>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }
                        else if (sqlDataReader["Tipo"].ToString().Equals("Otros"))
                        {
                            ProductoNoCongelado<EOtros> productoCongelado = new ProductoNoCongelado<EOtros>();

                            EOtros categoria = productoCongelado.ParceOtros(sqlDataReader["Nombre"].ToString());

                            productoCongelado = new ProductoNoCongelado<EOtros>(sqlDataReader["Nombre"].ToString(),
                                                                               (double)sqlDataReader["Precio"],
                                                                               (int)sqlDataReader["Codigo"],
                                                                               (int)sqlDataReader["Stock"],
                                                                               (bool)sqlDataReader["Stock_Si_No"],
                                                                               categoria);

                            listaProductos.Add(productoCongelado);
                        }

                    }

                }
            }
            catch (SqlException sqle)
            {
                Archivos<Exception>.SerializarExceptionATexto(sqle);
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }
            finally
            {
                Conexion.miConexion.Close();
            }

            return listaProductos;
        }


        public void InsertTicket(Ticket ticket)
        {

            #region INSERT de ProductoSeleccionado


            string query = $@"INSERT INTO [dbo].[ProductoSeleccionado] 
            ([CodigoProducto1],[Cantidad1]";

            for (int i = 2; i <= ticket.Lista_compra.Count; i++)
            {
                query += $",[CodigoProducto{i}],[Cantidad{i}]";
            }


            query += $") VALUES ({ ticket.Lista_compra[0].Codigo},{ ticket.Lista_compra[0].Cantidad}";



            for (int i = 1; i < ticket.Lista_compra.Count; i++)
            {
                query += $",{ticket.Lista_compra[i].Codigo},{ticket.Lista_compra[i].Cantidad}";
            }


            query += ")";

            EjecutarSql(query);

            #endregion



            #region Obtengo Id ProdSelec, mas alto

            int idProductoSeleccionado = 0;
            Conexion.comando.CommandText = "select Id from ProductoSeleccionado";

            try
            {
                Conexion.miConexion.Open();

                SqlDataReader sqlDataReader = Conexion.comando.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    idProductoSeleccionado = (int)sqlDataReader["Id"];
                }

            }
            catch (InvalidOperationException ioe)
            {
                Archivos<Exception>.SerializarExceptionATexto(ioe);
            }
            catch (InvalidCastException ice)
            {
                Archivos<Exception>.SerializarExceptionATexto(ice);
            }
            catch (SqlException sqle)
            {
                Archivos<Exception>.SerializarExceptionATexto(sqle);
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e);
            }
            finally
            {
                Conexion.miConexion.Close();
            }

            #endregion



            #region INSERT de Ticket    

            query = @$"INSERT INTO Ticket (IdProductoSeleccionado,Tipo,Fecha) VALUES ({idProductoSeleccionado},'{ticket.Tipo_de_ticket}','{ticket.FechaDate}')";

            EjecutarSql(query);


            #endregion
        }


        public static void UpDateInventario(List<Producto> listaProductoActualizada)
        {
            Conexion conexion = new Conexion();

            List<Producto> listaProductoBD = conexion.ObtenerInventario();
            List<Producto> listaProductosDesctualizados = new List<Producto>();

            foreach (Producto itemBD in listaProductoBD)
            {
                foreach (Producto itemActual in listaProductoActualizada)
                {
                    if (itemActual == itemBD && !(itemActual | itemBD))
                    {
                        listaProductosDesctualizados.Add(itemActual);
                    }
                }
            }

            foreach (Producto item in listaProductosDesctualizados)
            {
                Conexion.UpDateProducto(item);
            }

        }


        private static void UpDateProducto(Producto producto)
        {

            string query = @$" UPDATE [dbo].[Producto]
                                SET [Precio] = {producto.Precio},
                                    [Stock] = {producto.Stock},
                                    [Stock_SI_NO] = {producto.ParceBoolToInt(producto.Stock_SI_NO)}
                               WHERE codigo = {producto.Codigo}";

            EjecutarSql(query);

        }


        public static void EjecutarQuery(string query)
        {
            Conexion.comando.CommandText = query;


            try
            {
                Conexion.miConexion.Open();

                Conexion.comando.ExecuteNonQuery();

            }
            catch (InvalidOperationException ioe)
            {
                Archivos<Exception>.SerializarExceptionATexto(ioe);
            }
            catch (InvalidCastException ice)
            {
                Archivos<Exception>.SerializarExceptionATexto(ice);
            }
            catch (SqlException sqle)
            {
                Archivos<Exception>.SerializarExceptionATexto(sqle);
            }
            catch (Exception e)
            {
                Archivos<Exception>.SerializarExceptionATexto(e); 
            }
            finally
            {
                Conexion.miConexion.Close();
            }
        }


    }
}
