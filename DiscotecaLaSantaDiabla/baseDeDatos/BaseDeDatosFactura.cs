using DiscotecaLaSantaDiabla.logica;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    class BaseDeDatosFactura
    {
        static NpgsqlConnection conexion = new NpgsqlConnection();

        //INSERT INTO public.factura (id_usuario, nombre_usuario, apellido_usuario, telefono_usuario, nombre_bebida, cantidad_bebida, precio_subtotal, precio_total, fecha_factura) VALUES('', '', '', '', '', 0, 0, 0, '');

        //METODOS Factura
        //Metodo para agregar una bebida en la base de datos
        public static void agregarFactura(Cliente pUsuario, Producto pBebida, double pSubtotal, double pTotal, double pCantidadN)
        {

            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "INSERT INTO public.factura  (id_usuario, nombre_usuario, apellido_usuario, telefono_usuario, nombre_bebida, cantidad_bebida, precio_subtotal, precio_total, fecha_factura) VALUES('" + pUsuario.getID() + "'," + "'" + pUsuario.getNombre() + "','" + pUsuario.getApellido() + "','" + pUsuario.getTelefono() + "','" + pBebida.getNombre() + "'," + pCantidadN + "," + pSubtotal + "," + pTotal + "," + "NOW());"; //Sentencia SQL 

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar la factura a la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para mostrar Facturas en la base de datos
        public static DataSet mostrarFacturas()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM factura order by id_factura asc"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar las facturas de la base de datos. Error : " + e.ToString());
            }

            return datos;
        }

        public static DataSet obtenerUltimaFactura()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "select max(id_factura) from factura";
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos);
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Mostrar la factura. Error : " + e.ToString());
            }

            return datos;
        }

        public static DataSet buscarFactura(int pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM factura WHERE id_factura='" + pId + "';"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al buscar la bebida. Error : " + e.ToString());
            }

            return datos;
        }

        //METODOS EXTERNOS

        
        public static void listaFacturasBd()
        {
            String id_factura = "";
            String id_usuario = "";
            String nombre_usuario = "";
            String apellido_usuario = "";
            String telefono_usuario = "";
            String nombre_bebida = "";
            int cantidad_bebida = 0;
            double precio_subtotal = 0;
            double precio_total = 0;
            String fecha_factura = "";

            Factura.limpiarListaFacturas();

            foreach (DataRow dr in BaseDeDatosFactura.mostrarFacturas().Tables[0].Rows)
            {
                try
                {
                    id_factura = Convert.ToString(dr["id_factura"]);
                    id_usuario = Convert.ToString(dr["id_usuario"]);
                    nombre_usuario = Convert.ToString(dr["nombre_usuario"]);
                    apellido_usuario = Convert.ToString(dr["apellido_usuario"]);
                    telefono_usuario = Convert.ToString(dr["telefono_usuario"]);
                    nombre_bebida = Convert.ToString(dr["nombre_bebida"]);
                    cantidad_bebida = Convert.ToInt32(dr["cantidad_bebida"]);
                    precio_subtotal = Convert.ToDouble(dr["precio_subtotal"]);
                    precio_total = Convert.ToDouble(dr["precio_total"]);
                    fecha_factura = Convert.ToString(dr["fecha_factura"]);                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo listaFacturasBd" + ex.Message);
                }
                 try
                {
                    Factura factura = new Factura(id_factura, id_usuario, nombre_usuario, apellido_usuario, telefono_usuario, nombre_bebida, cantidad_bebida, precio_subtotal, precio_total, fecha_factura);
                    Factura.agregarFactura(factura);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear la lista de facturas->" + ex.Message);
                }

            }

        }
        

        public static int obtenerValorUltimaFactura()
        {
            int ultimaFactura = 0;
            try
            {
                ultimaFactura = Convert.ToInt32(BaseDeDatosFactura.obtenerUltimaFactura().Tables[0].Rows[0]["max"].ToString());
            }
            catch
            {
                MessageBox.Show("No se pudo obtener la ultima Factura realizadaa");
            }


            return ultimaFactura;
        }

        public static Factura crearFactura(int idFactura)
        {
            String id_factura = "";
            String id_usuario = "";
            String nombre_usuario = "";
            String apellido_usuario = "";
            String telefono_usuario = "";
            String nombre_bebida = "";
            int cantidad_bebida = 0;
            double precio_subtotal = 0;
            double precio_total = 0;
            String fecha_factura = "";

            Factura factura = null;

            foreach (DataRow dr in BaseDeDatosFactura.buscarFactura(idFactura).Tables[0].Rows)
            {
                try
                {
                    id_factura = Convert.ToString(dr["id_factura"]);
                    id_usuario = Convert.ToString(dr["id_usuario"]);
                    nombre_usuario = Convert.ToString(dr["nombre_usuario"]);
                    apellido_usuario = Convert.ToString(dr["apellido_usuario"]);
                    telefono_usuario = Convert.ToString(dr["telefono_usuario"]);
                    nombre_bebida = Convert.ToString(dr["nombre_bebida"]);
                    cantidad_bebida = Convert.ToInt32(dr["cantidad_bebida"]);
                    precio_subtotal = Convert.ToDouble(dr["precio_subtotal"]);
                    precio_total = Convert.ToDouble(dr["precio_total"]);
                    fecha_factura = Convert.ToString(dr["fecha_factura"]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo crearListaBd" + ex.Message);
                }

                try
                {
                    factura = new Factura(id_factura, id_usuario, nombre_usuario, apellido_usuario, telefono_usuario, nombre_bebida, cantidad_bebida, precio_subtotal, precio_total, fecha_factura);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear la bebida->" + ex.Message);
                }

            }

            return factura;
        }
    }
}
