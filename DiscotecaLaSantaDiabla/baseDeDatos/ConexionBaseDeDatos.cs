using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    static class ConexionBaseDeDatos
    {
        //Atributos para realizar la conexión a la Bd
        static NpgsqlConnection conexion = new NpgsqlConnection();

        static String servidor = "localhost";
        static String bd = "LaSantaDiabla";
        static String usuario = "postgres";
        static String password = "juanchog";
        static String puerto = "5432";

        static String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //Metodo para crear conexión
        public static NpgsqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se conecto correctamente a la base de datos");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se realizo la conexion a la base de datos. Error: " + e.ToString());
            }
            return conexion;
        }

        //Metodo para cerrar conexión
        public static NpgsqlConnection cerrarConexion()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
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

    }
}
