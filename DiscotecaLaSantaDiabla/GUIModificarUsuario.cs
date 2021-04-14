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

            try
            {
                cliente = Usuario.buscarUsuario(id);

                txtNombreB.Text = cliente.getNombre();
                txtApellidosB.Text = cliente.getApellido();
                txtTipoCuentaB.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonosB.Text = cliente.getTelefono();
                txtFecha.Text = cliente.getFechaN();
                Busqueda = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
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


                try
                {
                    if (txtNombre.Text.Trim().Equals("") &&
                        txtApellido.Text.Trim().Equals("") &&
                        txtTelefono.Text.Trim().Equals(""))
                    {
                        cliente.setNombre(txtNombreB.Text);
                        cliente.setApellido(txtApellidosB.Text);
                        cliente.setFechaN(comboFechaN.Text);
                        cliente.setTelefono(txtTelefonosB.Text);

                        Cliente.Cuentas tipoCuenta;

                        if (comboTipoCuenta.Text.Equals("VIP"))
                        {
                            tipoCuenta = Cliente.Cuentas.VIP;
                        }
                        else
                        {
                            tipoCuenta = Cliente.Cuentas.STANDAR;
                        }

                        cliente.setTipoCuenta(tipoCuenta);

                    }

                    if (txtNombre.Text.Trim().Equals(""))
                    {

                        cliente.setNombre(txtNombreB.Text);
                        
                    }
                    if(txtApellido.Text.Trim().Equals(""))
                    {
                        
                        cliente.setApellido(txtApellidosB.Text);
                    }
                    if(txtTelefono.Text.Trim().Equals(""))
                    {
                      
                        cliente.setTelefono(txtTelefonosB.Text);
                    }
                     
                    else
                    {
                        
                        cliente.setNombre(txtNombre.Text);
                        cliente.setApellido(txtApellido.Text);
                        cliente.setFechaN(comboFechaN.Text);
                        cliente.setTelefono(txtTelefono.Text);

                        Cliente.Cuentas tipoCuenta;

                        if (comboTipoCuenta.Text.Equals("VIP"))
                        {
                            tipoCuenta = Cliente.Cuentas.VIP;
                        }
                        else
                        {
                            tipoCuenta = Cliente.Cuentas.STANDAR;
                        }

                        cliente.setTipoCuenta(tipoCuenta);

                        MessageBox.Show("El usuario ha sido modificado");

                    }

                }
                catch (Exception er)
                {
                    MessageBox.Show("Ha ocurrido un error agregando el usuario" + er);
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
    }
}
