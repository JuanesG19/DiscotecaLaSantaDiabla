using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using DiscotecaLaSantaDiabla.baseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class GUIBuscarUsuario : Form
    {
        public GUIBuscarUsuario()
        {
            InitializeComponent();
        }

        Cliente cliente;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtIdentificacion.Text;

            String idCliente = "";
            string nombreCliente = "";
            string apellidoCliente = "";
            string telefonoCliente = "";
            string tipoCuentaCliente = "";
            string fechaUsuario = "";
            Membresia.Membresias membresias = Membresia.Membresias.STANDAR;


            DataSet busqueda = ConexionBaseDeDatos.buscarUsuario(id);


            foreach (DataRow dr in busqueda.Tables[0].Rows)
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

                    MessageBox.Show("Se agregaron las variables");
                    
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
                    MessageBox.Show("Se comparo si es VIP");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No Se pudo comparar si es VIP" + ex.Message);
                }

                try
                {
                    Cliente cliente = new Cliente(idCliente, nombreCliente, apellidoCliente, telefonoCliente, membresias, fechaUsuario);
                    MessageBox.Show("Se creo el cliente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo crear el usuario" + ex.Message);
                }

                if(cliente == null)
                {
                    MessageBox.Show("No existe el cliente solicitado");
                    return;
                }
                try
                {
                    txtNombres.Text = cliente.getNombre();
                    txtApellidos.Text = cliente.getApellido();
                    txtTipoCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
                    txtTelefonos.Text = cliente.getTelefono();
                    txtFechaN.Text = cliente.getFechaN();

                    MessageBox.Show("Se muestran los campos");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se mostraron los campos" + ex.Message);
                }

            }    
        }           
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GUIBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txtTipoCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
