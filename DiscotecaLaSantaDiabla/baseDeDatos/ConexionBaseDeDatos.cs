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
        static String bd = "laSantaDiabla";
        static String usuario = "postgres";
        static String password = "jorgerojas123";
        static String puerto = "5432";

        static String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //Metodo para crear conexión
        public static NpgsqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
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
