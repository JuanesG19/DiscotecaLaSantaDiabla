using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    static class ConexionBaseDeDatos
    {
        static NpgsqlConnection conexion = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "LaSantaDiabla";
        static String usuario = "postgres";
        static String password = "juanchog";
        static String puerto = "5432";

        static String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public static NpgsqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");
            }
            catch(NpgsqlException e)
            {
                MessageBox.Show("No se realizo la conexion a la base de datos. Error: " + e.ToString());
            }
            return conexion;
        }

        public static NpgsqlConnection cerrarConexion()
        {
            try
            {
                if(conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Conexion Cerrada");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cerrar la conexión. Error: " + e.ToString());
            }
            return conexion;
        }

        
        public static DataSet mostrarUsuario()
        {
            conexion = establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM usuario;"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos

                comando.Fill(datos); //POne los datos en el dataser
                conexion.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error al interactuar con la base de datos. Error : " + e.ToString() );
            }

            return datos;
        }

        public static DataSet buscarUsuario(String pId)
        {
            conexion = establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM usuario WHERE id_usuario='"+pId+"';"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                
                comando.Fill(datos); //POne los datos en el dataser
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al interactuar con la base de datos. Error : " + e.ToString());
            }

            return datos;
        }

        public static void agregarUsuario(String pId, String pNombre, String pApellido, String pFecha, String pTelefono,  String pTipoCuenta)
        {
            conexion = establecerConexion(); //Establece Conexion
            string sql = "INSERT INTO public.usuario (id_usuario, nombre_usuario, apellido_usuario, fechanat_usuario, telefono_usuario, tipocuenta_usuario) VALUES(" + pId + "," + "'" + pNombre + "'"+ "," + "'" + pApellido + "'" + "," +"'"+ pFecha + "'" + "," + pTelefono + ","+ "'" + pTipoCuenta + "'" + ");"; //Sentencia SQL 

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show(pNombre + ", Ha sido registrado con exito");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar el usuario a la base de datos. Error : " + e.ToString());
            }   
        }

        /**
        public static void actualizarUsuario(int pId, String pNombre, String pApellido, String pTelefono)
        {
            conexion = establecerConexion(); //Establece Conexion
            string sql = "INSERT INTO public.usuario (id_usuario, nombre_usuario, apellido_usuario, fechanat_usuario, telefono_usuario, tipocuenta_usuario) VALUES(" + pId + "," + "'" + pNombre + "'" + "," + "'" + pApellido + "'" + "," + "'" + pFecha + "'" + "," + pTelefono + "," + "'" + pTipoCuenta + "'" + ");"; //Sentencia SQL 

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show(pNombre + ", Ha sido registrado con exito");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar el usuario a la base de datos. Error : " + e.ToString());
            }
        }
        */

        public static void crearListaBd(){

            String idCliente = "";
            string nombreCliente = "";
            string apellidoCliente = "";
            string telefonoCliente = "";
            string tipoCuentaCliente = "";
            string fechaUsuario = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;



            foreach (DataRow dr in ConexionBaseDeDatos.mostrarUsuario().Tables[0].Rows)
            {
                try
                {
                    idCliente = Convert.ToString(dr["id_usuario"]);
                    nombreCliente = Convert.ToString(dr["nombre_usuario"]);
                    apellidoCliente = Convert.ToString(dr["apellido_usuario"]);
                    telefonoCliente = Convert.ToString(dr["telefono_usuario"]);
                    tipoCuentaCliente = Convert.ToString(dr["tipocuenta_usuario"]);
                    fechaUsuario = Convert.ToString(dr["fechanat_usuario"]);
                    membresias = Membresia.Membresias.STANDAR;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables" + ex.Message);
                }

                try
                {
                    if (tipoCuentaCliente.Equals(Membresia.Membresias.VIP))
                    {
                        membresias = Membresia.Membresias.VIP;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se pudo comparar si es VIP" + ex.Message);
                }

                try
                {
                    Cliente cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, telefonoCliente, membresias, fechaUsuario);
                    Usuario.crearUsuario(cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se crear el usuario" + ex.Message);
                }

            }
        }


    }
}
