using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using Npgsql;
using DiscotecaLaSantaDiabla.baseDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace DiscotecaLaSantaDiabla.baseDeDatos
{
    static class BaseDeDatosUsuario
    {
        static NpgsqlConnection conexion = new NpgsqlConnection();

        //METODOS USUARIO

        //Metodo para mostrar Usuarios registrados en la Bd
        public static DataSet mostrarUsuario()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM usuario order by id_usuario asc;"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos

                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al mostrar el usuario. Error : " + e.ToString());
            }

            return datos;
        }

        //Metodo para buscar Usuario en la Bd
        public static DataSet buscarUsuario(String pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM usuario WHERE id_usuario='" + pId + "';"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos

                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al buscar el usuario. Error : " + e.ToString());
            }

            return datos;
        }

        //Metodo para agregar un Usuario a la base de datos
        public static void agregarUsuario(String pId, String pNombre, String pApellido, String pFecha, String pTelefono, String pTipoCuenta)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "INSERT INTO public.usuario (id_usuario, nombre_usuario, apellido_usuario, fechanat_usuario, telefono_usuario, tipocuenta_usuario) VALUES(" + pId + "," + "'" + pNombre + "'" + "," + "'" + pApellido + "'" + "," + "'" + pFecha + "'" + "," + pTelefono + "," + "'" + pTipoCuenta + "'" + ");"; //Sentencia SQL 

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show(pNombre + ", Ha sido registrado con exito");
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Agregar el usuario a la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para modificar un Usuario a la base de datos
        public static void modificarUsuario(String pId, String pNombre, String pApellido, String pTelefono)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "UPDATE public.usuario SET nombre_usuario='"+pNombre+"', apellido_usuario='"+pApellido+"', telefono_usuario='"+pTelefono+"' WHERE id_usuario='" + pId + "';";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show(pNombre + ", Ha sido registrado con exito");
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al modificar el usuario a la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para eliminar un Usuario a la base de datos
        public static void eliminarUsuario(String pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion

            try
            {
                string sql = "DELETE FROM usuario WHERE id_usuario='" + pId + "';"; //Sentencia SQL
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                MessageBox.Show("El paciente ya fue eliminado, f");
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar el usuario de la base de datos. Error : " + e.ToString());
            }
        }

        //Metodo para modificar la membresia de un Usuario a la base de datos
        public static void modificarMembresia(String pId)
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            string sql = "UPDATE usuario SET tipocuenta_usuario='VIP' WHERE id_usuario='" + pId + "';";

            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conexion); //Almacena Datos
                comando.ExecuteNonQuery();
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al modificar el usuario a la base de datos. Error : " + e.ToString());
            }
        }
        
        //Metodo para mostrar Usuarios VIP a la base de datos
        public static DataSet mostrarUsuarioVIP()
        {
            conexion = ConexionBaseDeDatos.establecerConexion(); //Establece Conexion
            DataSet datos = new DataSet();

            try
            {
                string sql = "SELECT * FROM usuario WHERE tipocuenta_usuario='VIP' order by id_usuario asc"; //Sentencia SQL
                NpgsqlDataAdapter comando = new NpgsqlDataAdapter(sql, conexion); //Almacena Datos
                comando.Fill(datos); //POne los datos en el dataser
                ConexionBaseDeDatos.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al Mostrar el usuario VIP en la base de datos. Error : " + e.ToString());
            }

            return datos;
        }

        //METODOS BEBIDAS

        //METODOS EXTERNOS

        public static void crearListaBd()
        {
            String idCliente = "";
            string nombreCliente = "";
            string apellidoCliente = "";
            string telefonoCliente = "";
            string tipoCuentaCliente = "";
            string fechaUsuario = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;

            Usuario.limpiarLista();

            foreach (DataRow dr in BaseDeDatosUsuario.mostrarUsuario().Tables[0].Rows)
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
                    if (tipoCuentaCliente.Equals("VIP"))
                    {
                        membresias = Membresia.Membresias.VIP;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se pudo comparar si es VIP" + ex.Message);
                }

                try
                {
                    Cliente cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, telefonoCliente, membresias, fechaUsuario);
                    Usuario.crearUsuario(cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el usuario ->" + ex.Message);
                }

            }
        }

        public static void crearListaVIPBd()
        {
            String idCliente = "";
            string nombreCliente = "";
            string apellidoCliente = "";
            string telefonoCliente = "";
            string tipoCuentaCliente = "";
            string fechaUsuario = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;

            Usuario.limpiarLista();

            foreach (DataRow dr in BaseDeDatosUsuario.mostrarUsuarioVIP().Tables[0].Rows)
            {
                try
                {
                    idCliente = Convert.ToString(dr["id_usuario"]);
                    nombreCliente = Convert.ToString(dr["nombre_usuario"]);
                    apellidoCliente = Convert.ToString(dr["apellido_usuario"]);
                    telefonoCliente = Convert.ToString(dr["telefono_usuario"]);
                    tipoCuentaCliente = Convert.ToString(dr["tipocuenta_usuario"]);
                    fechaUsuario = Convert.ToString(dr["fechanat_usuario"]);
                    membresias = Membresia.Membresias.VIP;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo crearListaVIPBd" + ex.Message);
                }
                try
                {
                    Cliente cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, telefonoCliente, membresias, fechaUsuario);
                    Usuario.crearUsuario(cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el usuario ->" + ex.Message);
                }

            }
        }

        public static Cliente buscarClienteBd(String pId)
        {
            String idCliente = "";
            string nombreCliente = "";
            string apellidoCliente = "";
            string telefonoCliente = "";
            string tipoCuentaCliente = "";
            string fechaUsuario = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;

            Cliente cliente = null;

            foreach (DataRow dr in buscarUsuario(pId).Tables[0].Rows)
            {
                try
                {
                    if (Convert.ToString(dr["id_usuario"]).Equals("") || Convert.ToString(dr["id_usuario"]) == null)
                    {
                        MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                        DialogResult dR = MessageBox.Show("El usuario que desea buscar no se encuentra registrado ¿Desea registrarlo?", "Usuario no encontrado", botonesConf);

                        if (dR == DialogResult.Yes)
                        {
                            GUIAgregar agregar = new GUIAgregar();
                            agregar.Show();
                        }
                    }
                    else
                    {
                        idCliente = Convert.ToString(dr["id_usuario"]);
                        nombreCliente = Convert.ToString(dr["nombre_usuario"]);
                        apellidoCliente = Convert.ToString(dr["apellido_usuario"]);
                        telefonoCliente = Convert.ToString(dr["telefono_usuario"]);
                        tipoCuentaCliente = Convert.ToString(dr["tipocuenta_usuario"]);
                        fechaUsuario = Convert.ToString(dr["fechanat_usuario"]);
                        membresias = Membresia.Membresias.STANDAR;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo obtener la informacion en las variables metodo buscarClienteBd" + ex.Message);
                }
                try
                {
                    if (tipoCuentaCliente.Equals("VIP"))
                    {
                        membresias = Membresia.Membresias.VIP;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se pudo comparar si es VIP metodo buscarClienteBd" + ex.Message);
                }

                try
                {
                    cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, telefonoCliente, membresias, fechaUsuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo buscar el usuario metodo buscarClienteBd " + ex.Message);
                }

            }

            return cliente;
        }

    }
}
