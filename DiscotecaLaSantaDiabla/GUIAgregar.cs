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
    public partial class GUIAgregar : Form
    {
        public GUIAgregar()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int identificacion = Convert.ToInt32(txtIdentificacion.Text);
            String nombre = txtNombres.Text;
            String apellidos = txtApellidos.Text;
            Cliente.TipoCuentaUsuario tipocuenta = Cliente.TipoCuentaUsuario.STANDAR; 
            long telefono = Convert.ToInt64(txtTelefonos.Text);
            String fecha = fechaNacimiento.Value.ToString();

            Usuario user = new Usuario();

            try
            {
                Cliente cliente = new Cliente(identificacion, nombre, apellidos, tipocuenta, telefono, fecha);
                user.crearUsuario(cliente);
            }
            catch
            {
                throw new Exception("No se pudo agregar el cliente!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
