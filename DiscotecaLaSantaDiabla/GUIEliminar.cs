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
    public partial class GUIEliminar : Form
    {
        public GUIEliminar()
        {
            InitializeComponent();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        Cliente cliente;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id = txtIdentificacion.Text;

            try
            {
                cliente = Usuario.buscarUsuario(id);

                txtNombres.Text = cliente.getNombre();
                txtApellidos.Text = cliente.getApellido();
                txtTipoDeCuenta.Text = Convert.ToString(cliente.getTipoCuenta());
                txtTelefonos.Text = cliente.getTelefono();
                txtFechaN.Text = cliente.getFechaN();

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("Desea Eliminar a: " + cliente.getNombre() + "?", "Eliminar", botones);

                if(dr == DialogResult.Yes)
                {
                    try
                    {
                        Usuario.eliminarUsuario(id);
                        MessageBox.Show(cliente.getNombre() + ", Ha sido Eliminado!");
                    }
                    catch
                    {
                        throw new Exception("No se pudo eliminar a: " + cliente.getNombre());
                    }
                    
                }
                else
                {
                    this.Close();
                }

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
