using DiscotecaLaSantaDiabla.logica;
using Npgsql;
using System;
using System.Collections.Generic;
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
            string sql = "INSERT INTO public.factura  (id_usuario, nombre_usuario, apellido_usuario, telefono_usuario, nombre_bebida, cantidad_bebida, precio_subtotal, precio_total, fecha_factura) VALUES('" + pUsuario.getID() + "'," + "'" + pUsuario.getNombre() + "','" + pUsuario.getApellido() + "','" + pUsuario.getTelefono() + "','" + pBebida.getNombre() + "'," + pCantidadN +","+pSubtotal + "," +pTotal +"," +"NOW());"; //Sentencia SQL 

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
    }
}
