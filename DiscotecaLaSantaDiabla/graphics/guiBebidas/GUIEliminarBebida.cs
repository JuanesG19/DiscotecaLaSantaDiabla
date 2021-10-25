using DiscotecaLaSantaDiabla.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DiscotecaLaSantaDiabla.baseDeDatos;


namespace DiscotecaLaSantaDiabla.graphics.guiBebidas
{
    public partial class GUIEliminarBebida : Form
    {
        public GUIEliminarBebida()
        {
            InitializeComponent();
        }

        Producto bebida;       
        Boolean Busqueda = false;

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            String id = txtIdentificador.Text;

            bebida = BaseDeDatosBebida.buscarBebidaBd(id);

            if (bebida == null)
            {
                MessageBox.Show("No existe el usuario a eliminar");
                return;
            }

            txtNombre.Text = bebida.getNombre();
            txtPrecio.Text = Convert.ToString(bebida.getPrecio().ToString("C", CultureInfo.CurrentCulture));
            txtPresentacion.Text = bebida.getPresentacion();
            txtCantidad.Text = Convert.ToString(bebida.getCantidad());
            txtTipoBebida.Text = Convert.ToString(bebida.getTipoBebida());

            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("Desea Eliminar a: " + bebida.getNombre() + "?", "Eliminar", botones);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    BaseDeDatosBebida.eliminarBebida(bebida.getIdBebida());
                    MessageBox.Show("La bebida " + bebida.getNombre() + ", Ha sido Eliminada!");
                    this.Close();
                }
                catch
                {
                    throw new Exception("No se pudo eliminar a: " + bebida.getNombre());
                }

            }
            else
            {
                this.Close();
            }
        }         
                  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
