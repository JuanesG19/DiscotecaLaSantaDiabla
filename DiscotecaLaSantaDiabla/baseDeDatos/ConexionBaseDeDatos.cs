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

        
        public static DataSet mostrar()
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

        public static void agregarUsuario(int pId, String pNombre, String pApellido, String pFecha, String pTelefono,  String pTipoCuenta)
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


    }
}
