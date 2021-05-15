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

            
                cliente = Usuario.buscarUsuario(id);
                if (cliente == null)
                {
                    MessageBox.Show("El usuario buscado no existe");
                    return;
                }              
                txtNombreB.Text = cliente.getNombre();
                txtApellidosB.Text = cliente.getApellido();
                txtTipoCuentaB.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonosB.Text = cliente.getTelefono();
                txtFecha.Text = cliente.getFechaN();
                Busqueda = true;          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(Busqueda == true)
            {
                String id = txtIdentificacion.Text;

                cliente = Usuario.buscarUsuario(id);

                if (txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtTelefono.Text.Length == 0 || comboFechaN.Text.Length == 0)
                {
                    MessageBox.Show("Hay espacios vacios, No se ha podido modificar el usuario");
                    return;
                }              
                if (!comboTipoCuenta.Text.Equals("VIP") && !comboTipoCuenta.Text.Equals("STANDAR"))
                {
                    MessageBox.Show("El tipo de la cuenta no es valido");
                    return;
                }
                else
                    {                       
                        cliente.setNombre(txtNombre.Text);
                        cliente.setApellido(txtApellido.Text);
                        cliente.setFechaN(comboFechaN.Text);
                        cliente.setTelefono(txtTelefono.Text);

                        Cuenta.Cuentas tipoCuenta;

                        if (comboTipoCuenta.Text.Equals("VIP"))
                        {
                            tipoCuenta = Cuenta.Cuentas.VIP;
                        }
                        else
                        {
                            tipoCuenta = Cuenta.Cuentas.STANDAR;
                        }

                        cliente.setTipoCuenta(tipoCuenta);

                        MessageBox.Show("El usuario ha sido modificado");

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
