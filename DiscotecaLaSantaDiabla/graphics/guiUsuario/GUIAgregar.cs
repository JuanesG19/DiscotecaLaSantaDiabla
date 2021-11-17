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
    public partial class GUIAgregar : Form
    {
        public GUIAgregar()
        {
            InitializeComponent();
        }
       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text.Length == 0 || txtNombres.Text.Length == 0 || txtApellidos.Text.Length == 0 || txtTelefonos.Text.Length == 0 || fechaNacimiento.Value.ToString().Length == 0)
            {
                MessageBox.Show("Hay espacios vacios, No se ha podido agregar el usuario");
                return;
            }

            String identificacion = txtIdentificacion.Text;
            String nombre = txtNombres.Text;
            String apellidos = txtApellidos.Text;
            String telefono = txtTelefonos.Text;
            String fecha = Convert.ToString(fechaNacimiento.Value.ToString("dd/MM/yyyy"));
            String membresia = Convert.ToString(Membresia.Membresias.STANDAR);

            DateTime edadActual = fechaNacimiento.Value.AddYears(18);

            if (edadActual <= DateTime.Today)
            {
                try
                {
                    BaseDeDatosUsuario.agregarUsuario(identificacion, nombre, apellidos, fecha, telefono, membresia);

                    txtIdentificacion.Text = "";
                    txtNombres.Text = "";
                    txtApellidos.Text = "";
                    txtTelefonos.Text = "";
                    fechaNacimiento.Text = "";

                }
                catch
                {
                    MessageBox.Show("Campos Invalidos, Intente de nuevo");
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

        private void fechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
