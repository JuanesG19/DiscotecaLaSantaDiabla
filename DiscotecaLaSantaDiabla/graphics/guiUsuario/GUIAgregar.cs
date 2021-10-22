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

            if(identificacion.Length == 0 || nombre.Length == 0 || apellidos.Length == 0 || telefono.Length == 0 || fecha.Length == 0)
            {
                MessageBox.Show("Hay espacios vacios, No se ha podido agregar el usuario");
                return;
            }

            Cuenta.Cuentas tipoCuenta;

            if (!txtTipoDeCuenta.Text.Equals("VIP") && !txtTipoDeCuenta.Text.Equals("STANDAR"))
            {
                MessageBox.Show("El tipo de la cuenta no es valido");
                return;
            }
            else if (txtTipoDeCuenta.Text.Equals("STANDAR"))
            {
                tipoCuenta = Cuenta.Cuentas.STANDAR;
            }
            else
            {
                tipoCuenta = Cuenta.Cuentas.VIP;
            }

            DateTime edadActual = fechaNacimiento.Value.AddYears(18);

            if ( edadActual <= DateTime.Today )
            {
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
            else
            {
                MessageBox.Show("El usuario NO es mayor de edad");
                return;
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
