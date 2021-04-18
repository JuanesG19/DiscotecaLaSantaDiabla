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
    public partial class GUIBuscarUsuario : Form
    {
        public GUIBuscarUsuario()
        {
            InitializeComponent();
        }

        Cliente cliente;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             String id = txtIdentificacion.Text;

            try
            {
                cliente = Usuario.buscarUsuario(id);

                txtNombres.Text = cliente.getNombre();
                txtApellidos.Text = cliente.getApellido();
                txtTipoCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonos.Text = cliente.getTelefono();
                txtFechaN.Text = cliente.getFechaN();
            }
            catch(Exception ex)
            {
               throw new Exception( ex.Message);
                
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
