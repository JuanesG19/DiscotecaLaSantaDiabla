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

            Cuenta.Cuentas tipoCuenta;

            if (txtTipoDeCuenta.Text.Equals("VIP"))
            {
                tipoCuenta = Cuenta.Cuentas.VIP;
            }
            else
            {
                tipoCuenta = Cuenta.Cuentas.STANDAR;
            }

            try
            {
                Cliente cliente = new Cliente(identificacion, nombre, apellidos, telefono, tipoCuenta, fecha);
                Usuario.crearUsuario(cliente);

                txtIdentificacion.Text = "";
                txtNombres.Text = "";
                txtApellidos.Text = "";
                txtTelefonos.Text = "";
                txtTipoDeCuenta.Text = "";

                MessageBox.Show(cliente.getNombre() + ", Ha sido registrado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUIAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
