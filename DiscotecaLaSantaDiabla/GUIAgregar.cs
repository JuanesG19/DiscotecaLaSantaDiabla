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
            String identificacion = txtIdentificacion.Text;
            String nombre = txtNombres.Text;
            String apellidos = txtApellidos.Text;
            String telefono = txtTelefonos.Text;
            String fecha = fechaNacimiento.Value.ToString();
            Cliente.Cuentas tipocuenta = Cliente.Cuentas.STANDAR;

            Usuario user = new Usuario();

            try
            {
                Cliente cliente = new Cliente(identificacion, nombre, apellidos, telefono, tipocuenta, fecha);
                user.crearUsuario(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
