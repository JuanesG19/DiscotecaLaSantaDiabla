using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DiscotecaLaSantaDiabla.graphics.guiBebidas;
using DiscotecaLaSantaDiabla.logica;
using Npgsql;


namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    static class BaseDeDatosBebida
    {

        static NpgsqlConnection conexion = new NpgsqlConnection();

        //METODOS Bebida

        //Metodo para mostrar bebidas registradas en la Bd
        public static DataSet mostrarBebida()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM bebidas order by id_bebida asc;"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos

                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Mostrar la bebida. Error : " + e.ToString());
            }

            return datos;
        }

        //Metodo para buscar una bebida en la Bd
        public static DataSet buscarBebida(String pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM bebidas WHERE id_bebida='" + pId + "';"; //Sentencia SQL
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

        //Metodo para agregar una bebida en la base de datos
        public static void agregarBebida(String pId, String pNombre, double pPrecio, String pPresentacion, int pCantidad, String pTipoBebida)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "INSERT INTO bebidas (id_bebida, nombre_bebida, precio_bebida, presentacion_bebida, cantidad_bebida, tipo_bebida) VALUES('"+ pId +"'," + "'" + pNombre + "'," + pPrecio  + "," + "'" + pPresentacion + "'," + pCantidad + "," + "'" + pTipoBebida + "'" + ");"; //Sentencia SQL 

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar la bebida a la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para modificar una bebida de la base de datos
        public static void modificarBebida(String pId, String pNombre, double pPrecio, String pPresentacion, int pCantidad, String pTipoBebida)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "UPDATE public.bebidas SET nombre_bebida = " + "'" + pNombre + "', precio_bebida =" + pPrecio + " , presentacion_bebida = '" + pPresentacion + "', cantidad_bebida = "+pPrecio + ", tipo_bebida = '" + pTipoBebida + "'WHERE id_bebida = '" + pId + "'; ";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show("La bebida " + pNombre + ", Ha sido Modificada con exito");
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar en la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para eliminar una bebida a la base de datos
        public static void eliminarBebida(String pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion

            try
            {
                string sql = "DELETE FROM public.bebidas WHERE id_bebida='" + pId + "';"; //Sentencia SQL
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar la bebida en la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para mostrar Usuarios VIP a la base de datos
        public static DataSet mostrarBebidasVIP()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM bebidas WHERE tipo_bebida='VIP' order by id_bebida asc"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar las bebidas VIP. Error : " + e.ToString());
            }

            return datos;
        }

        //METODOS BEBIDAS

        //METODOS EXTERNOS

        public static void crearListaBd()
        {
            String idBebida = "";
            string nombreBebida = "";
            double precioBebida = 0;
            string presentacionBebida = "";
            int cantidadBebida = 0;
            string tipoBebida = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;

            Bebida.limpiarListaBebida();

            foreach (DataRow dr in BaseDeDatosBebida.mostrarBebida().Tables[0].Rows)
            {
                try
                {
                    idBebida = Convert.ToString(dr["id_bebida"]);
                    nombreBebida = Convert.ToString(dr["nombre_bebida"]);
                    precioBebida = Convert.ToDouble(dr["precio_bebida"]);
                    presentacionBebida = Convert.ToString(dr["presentacion_bebida"]);
                    cantidadBebida = Convert.ToInt32(dr["cantidad_bebida"]);
                    tipoBebida = Convert.ToString(dr["tipo_bebida"]);
                    membresias = Membresia.Membresias.STANDAR;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo crearListaBd" + ex.Message);
                }

                try
                {
                    if (tipoBebida.Equals("VIP"))
                    {
                        membresias = Membresia.Membresias.VIP;
                    }
                    else
                    {
                         membresias = Membresia.Membresias.STANDAR ;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se pudo comparar si es VIP" + ex.Message);
                }

                try
                {
                    Producto bebida = new Producto(idBebida, nombreBebida, precioBebida, presentacionBebida, cantidadBebida, membresias);
                    Bebida.agregarBebida(bebida);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear la bebida->" + ex.Message);
                }

            }
        }

        public static void crearListaVIPBd()
        {
            String idBebida = "";
            string nombreBebida = "";
            double precioBebida = 0;
            string presentacionBebida = "";
            int cantidadBebida = 0;
            string tipoBebida = "";
            Membresia.Membresias membresias = Membresia.Membresias.VIP;

            Bebida.limpiarListaBebida();

            foreach (DataRow dr in BaseDeDatosBebida.mostrarBebidasVIP().Tables[0].Rows)
            {
                try
                {
                    idBebida = Convert.ToString(dr["id_bebida"]);
                    nombreBebida = Convert.ToString(dr["nombre_bebida"]);
                    precioBebida = Convert.ToDouble(dr["precio_bebida"]);
                    presentacionBebida = Convert.ToString(dr["presentacion_bebida"]);
                    cantidadBebida = Convert.ToInt32(dr["cantidad_bebida"]);
                    tipoBebida = Convert.ToString(dr["tipo_bebida"]);
                    membresias = Membresia.Membresias.VIP;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo crearListaVIPBd" + ex.Message);
                }
                try
                {
                    Producto bebida = new Producto(idBebida, nombreBebida, precioBebida, presentacionBebida, cantidadBebida, membresias);
                    Bebida.agregarBebida(bebida);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo mostrar las bebidas VIP ->" + ex.Message);
                }

            }
        }

        public static Producto buscarBebidaBd(String pId)
        {
            String idBebida = "";
            string nombreBebida = "";
            double precioBebida = 0;
            string presentacionBebida = "";
            int cantidadBebida = 0;
            string tipoBebida = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;

            Producto bebida = null;

            foreach (DataRow dr in buscarBebida(pId).Tables[0].Rows)
            {
                try
                {
                    if (Convert.ToString(dr["id_bebida"]).Equals("") || Convert.ToString(dr["id_bebida"]) == null)
                    {
                        MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                        DialogResult dR = MessageBox.Show("La bebida que desea buscar no se encuentra registrada ¿Desea registrarla?", "Bebida no encontrada", botonesConf);

                        if (dR == DialogResult.Yes)
                        {
                            GUIAgregarBebida agregarBebida = new GUIAgregarBebida();
                            agregarBebida.Show();
                        }
                    }
                    else
                    {
                        idBebida = Convert.ToString(dr["id_bebida"]);
                        nombreBebida = Convert.ToString(dr["nombre_bebida"]);
                        precioBebida = Convert.ToDouble(dr["precio_bebida"]);
                        presentacionBebida = Convert.ToString(dr["presentacion_bebida"]);
                        cantidadBebida = Convert.ToInt32(dr["cantidad_bebida"]);
                        tipoBebida = Convert.ToString(dr["tipo_bebida"]);
                        membresias = Membresia.Membresias.STANDAR;
                        MessageBox.Show("Se agregaron las variables");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo buscarBebidaBd" + ex.Message);
                }
                try
                {
                    if (tipoBebida.Equals("VIP"))
                    {
                        membresias = Membresia.Membresias.VIP;
                        MessageBox.Show("Se comparo si es VIP");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se pudo comparar si es VIP metodo buscarBebidaBd" + ex.Message);
                }

                try
                {
                    bebida = new Producto(idBebida, nombreBebida, precioBebida, presentacionBebida, cantidadBebida, membresias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo buscar el usuario " + ex.Message);
                }

            }

            return bebida;
        }
    }
}
