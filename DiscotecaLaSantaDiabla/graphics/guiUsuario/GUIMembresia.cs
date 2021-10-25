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
using static DiscotecaLaSantaDiabla.logica.Membresia;

namespace DiscotecaLaSantaDiabla.graphics.guiUsuario
{
    public partial class GUIMembresia : Form
    {
        public GUIMembresia()
        {
            InitializeComponent();
        }



        private void GUIMembresia_Load(object sender, EventArgs e)
        {

        }

        Cliente cliente = null;
        Boolean Busqueda = false;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtIdentificacion.Text;
            cliente = BaseDeDatosUsuario.buscarClienteBd(id);

            if (cliente == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("El usuario que desea buscar no se encuentra registrado ¿Desea registrarlo?", "Usuario no encontrado", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                else
                {
                    return;
                }
        
            }
            else
            {
                txtNombres.Text = cliente.getNombre();
                txtApellidos.Text = cliente.getApellido();
                txtTipoCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonos.Text = cliente.getTelefono();
                txtFechaN.Text = cliente.getFechaN();
                Busqueda = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(Busqueda == false)
            {
                MessageBox.Show("Es necesario buscar a el usuario antes de actualizar la membresia");
                return;
            }
            else if(txtTipoCuenta.Text.Equals("VIP"))
            {
                MessageBox.Show("No puede convertir a un cliente VIP en VIP", "Error");
                return;
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("El costo de la Membresia VIP es $150.000 ¿Desea actualizar su membresia?", "Actualizar Membresia", botones);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        BaseDeDatosUsuario.modificarMembresia(cliente.getID());
                        MessageBox.Show("Bienvenido a nuestra comunidad VIP: " + cliente.getNombre());
                        this.Close();
                    }
                    catch
                    {
                        throw new Exception("No se pudo cambiar el estado de la membresia");
                    }

                }
                else
                {
                    return;
                }
            }
        }
    }
}

