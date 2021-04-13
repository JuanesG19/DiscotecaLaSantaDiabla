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
        Usuario user = new Usuario();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
             String id = txtIdentificacion.Text;

            try
            {
                cliente = user.buscarUsuario(id);

                txtNombres.Text = cliente.getNombre();
                txtApellidos.Text = cliente.getApellido();
                txtTipoDeCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
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
    }
}
