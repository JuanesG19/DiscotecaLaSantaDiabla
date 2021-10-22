using DiscotecaLaSantaDiabla.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla.graphics.guiBebidas
{
    public partial class GUIEliminarBebida : Form
    {
        public GUIEliminarBebida()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {
               id = Int32.Parse(txtIdentificador.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un identificador valido");
                return;
            }

            Producto buscada = Bebida.buscarBebida(id);

            if (buscada == null)
            {
                MessageBox.Show("No existe la bebida buscada");
                return;
            }
                txtNombre.Text = buscada.getNombre();
                txtPrecio.Text = Convert.ToString(buscada.getPrecio());
                txtPresentacion.Text = buscada.getPresentacion();
                txtCantidad.Text = Convert.ToString(buscada.getCantidad());
                txtTipoBebida.Text = Convert.ToString(buscada.getTipoBebida());

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("Desea Eliminar a: " + buscada.getNombre() + "?", "Eliminar", botones);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Bebida.eliminarBebida(id);
                        MessageBox.Show(buscada.getNombre() + ", Ha sido Eliminado!");
                        this.Close();
                    }
                    catch  (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            this.Close();
        }         
                  

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
