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
    public partial class GUIModificarBebida : Form
    {
        public GUIModificarBebida()
        {
            InitializeComponent();
        }

        Producto bebida;
        Boolean Busqueda = false;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
                int id = Int32.Parse(txtIdentificadorB.Text);


            try
            {
                bebida = Bebida.buscarBebida(id);
                txtNombre.Text = bebida.getNombre();
                txtPrecio.Text = Convert.ToString(bebida.getPrecio());
                txtPresentacion.Text = bebida.getPresentacion();
                txtCantidad.Text = Convert.ToString(bebida.getCantidad());               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (Busqueda == true)
            {

                int id = Int32.Parse(txtIdentificadorB.Text);

                bebida = Bebida.buscarBebida(id);


                try
                {
                    bebida.setNombre(txtNombreB.Text);
                    bebida.setPrecio(Double.Parse(txtPrecioB.Text));
                    bebida.setPresentacion(txtPresentacionB.Text);
                    bebida.setCantidad(Convert.ToInt32(txtCantidadB.Text));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
