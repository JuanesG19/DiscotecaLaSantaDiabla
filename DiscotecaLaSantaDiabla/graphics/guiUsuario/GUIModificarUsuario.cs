using DiscotecaLaSantaDiabla.baseDeDatos;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class GUIModificarUsuario : Form
    {
        public GUIModificarUsuario()
        {
            InitializeComponent();
        }

        Cliente cliente;
        Boolean Busqueda = false;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtIdentificacion.Text;
            Cliente cliente = BaseDeDatosUsuario.buscarClienteBd(id);

            if (cliente == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("El usuario que desea buscar no se encuentra registrado ¿Desea registrarlo?", "Usuario no encontrado", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                else if (dR == DialogResult.No)
                {
                    this.Close();
                }

            }
            else
            {
                txtNombreB.Text = cliente.getNombre();
                txtApellidosB.Text = cliente.getApellido();
                txtTipoCuentaB.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonosB.Text = cliente.getTelefono();
                txtFecha.Text = cliente.getFechaN();
                Busqueda = true;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Busqueda == true)
            {
                String id = txtIdentificacion.Text;

                if (txtNombre.Text.Length == 0)
                {
                    txtNombre.Text = txtNombreB.Text;
                }
                if (txtApellido.Text.Length == 0)
                {
                    txtApellido.Text = txtApellidosB.Text;
                }
                if (txtTelefono.Text.Length == 0)
                {
                    txtTelefono.Text = txtTelefonosB.Text;
                }

                try
                {
                   BaseDeDatosUsuario.modificarUsuario(id, txtNombre.Text, txtApellido.Text, txtTelefono.Text);
                    MessageBox.Show("El usuario ha sido modificado con exito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido modificar el usuario" + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Es necesario realizar primeramente una busqueda del usuario a modificar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
