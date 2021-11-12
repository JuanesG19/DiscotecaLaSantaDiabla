using DiscotecaLaSantaDiabla.graphics.guiUsuario;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using static DiscotecaLaSantaDiabla.logica.Membresia;

namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    static class BaseDeDatosZonas
    {

        static NpgsqlConnection conexion = new NpgsqlConnection();

        //1. Modificar la capacidad actual (UPDATE)
        public static void modificarCapacidaZona(int pId, int pCantidad)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "UPDATE public.zonas SET cactual_zona=" + pCantidad + "WHERE id_zona=" + pId + ";";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Modificar la cantidad de la zona en la base de datos. Error : " + e.ToString());
            }
        }

        //2. Buscar la Zona (Devolver DataSet)
        public static DataSet buscarZona(int pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM zonas WHERE id_zona='" + pId + "';"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al buscar la zona. Error : " + e.ToString());
            }

            return datos;
        }

        //4. Buscar la Zona (Zona)

        public static Zona buscarZonaBd(int pId)
        {
            int idZona = 0;
            string tipoZona = "";
            int capacidadMaxima = 0;
            int capacidadActual = 0;

            Zona zona = null;

            foreach (DataRow dr in buscarZona(pId).Tables[0].Rows)
            {
                try
                {
                    idZona = Convert.ToInt32(dr["id_zona"]);
                    tipoZona = Convert.ToString(dr["tipo_zona"]);
                    capacidadMaxima = Convert.ToInt32(dr["cmaxima_zona"]);
                    capacidadActual = Convert.ToInt32(dr["cactual_zona"]);

                    zona = new Zona(idZona, tipoZona, capacidadMaxima, capacidadActual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo buscarZonaBd" + ex.Message);
                }
            }
            return zona;
        }

        //3. Modificar la cantidad actual (Externo)

        public static void modificarCapacidadBd(int pId, int pCantidad, string idUser)
        {
            int Ncantidad;
            int exceso;

            Zona zona = buscarZonaBd(pId);

            Cliente cliente = BaseDeDatosUsuario.buscarClienteBd(idUser);

            Ncantidad = zona.getCapacidaActual() + pCantidad;

            if (zona.getCapacidaActual() == zona.getCapacidadMaxima())
            {
                MessageBox.Show("La Zona " + zona.getTipoZona() + " se encuentra al maximo de su capacidad");
            }
            else if(Ncantidad > zona.getCapacidadMaxima())
            {
                exceso = Ncantidad - zona.getCapacidadMaxima();
                MessageBox.Show("Se excedio el cupo de la zona Especial por: " + exceso + " persona(s)");
            }
            else 
            {
                if (cliente.getTipoCuenta().Equals("VIP") && zona.getTipoZona().Equals("VIP"))
                {
                    modificarCapacidaZona(pId, Ncantidad);
                    MessageBox.Show("Se han ingresado los clientes!");
                }
                else if ((cliente.getTipoCuenta().Equals(Membresias.STANDAR) && zona.getTipoZona().Equals("VIP")))
                {
                    MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                    DialogResult dR = MessageBox.Show("Acceso a zona VIP restringido. El usuario no cuenta con membresia VIP ¿Desea actualizar su membresia a VIP?", "Actualizar Membresia", botonesConf);

                    if (dR == DialogResult.Yes)
                    {
                        GUIMembresia agregar = new GUIMembresia();
                        agregar.Show();
                    }
                    else if (dR == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    modificarCapacidaZona(pId, Ncantidad);
                    MessageBox.Show("Se han ingresado los clientes!");
                }
            }
        }

        public static void salidaZonaBd(int pId, int pCantidad)
        {
            Zona zona = buscarZonaBd(pId);
            int temp = zona.getCapacidaActual();
            int salida = temp - pCantidad;

            if (temp == 0)
            {
                MessageBox.Show("No hay personas en la zona A Actualmente");
            }
            else if (salida < 0)
            {
                MessageBox.Show("No se puede desalojar este numero de personas, solo hay " + temp
                                   + " Personas en la zona");
            }
            else
            {
                modificarCapacidaZona(pId, salida);
                Zona nuevaZona = buscarZonaBd(pId);
                MessageBox.Show("Los usuarios han sido retirados. Capacidad Actual de la Zona: " + zona.getTipoZona() + " es de " + nuevaZona.getCapacidaActual() + " personas");
            }
        }

    }
}
