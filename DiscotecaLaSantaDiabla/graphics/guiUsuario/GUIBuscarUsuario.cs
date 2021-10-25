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



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id = txtIdentificacion.Text;
            Cliente cliente = BaseDeDatosUsuario.buscarClienteBd(id);

            if(cliente == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("El usuario que desea buscar no se encuentra registrado ¿Desea registrarlo?", "Usuario no encontrado", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                else if(dR == DialogResult.No)
                {
                    this.Close();
                }
            
            }
            else
            {
                txtNombres.Text = cliente.getNombre();
                txtApellidos.Text = cliente.getApellido();
                txtTipoCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonos.Text = cliente.getTelefono();
                txtFechaN.Text = cliente.getFechaN();
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