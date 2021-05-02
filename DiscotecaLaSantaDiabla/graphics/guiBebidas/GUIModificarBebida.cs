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
        Boolean busqueda = false;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
                int id = Int32.Parse(txtIdentificadorB.Text);


            try
            {
                bebida = Bebida.buscarBebida(id);
                busqueda = true;
                txtNombreB.Text = bebida.getNombre();
                txtPrecioB.Text = Convert.ToString(bebida.getPrecio());
                txtPresentacionB.Text = bebida.getPresentacion();
                txtCantidadB.Text = Convert.ToString(bebida.getCantidad());               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (busqueda == true)
            {

                int id = Int32.Parse(txtIdentificadorB.Text);

                bebida = Bebida.buscarBebida(id);


                try
                {
                    bebida.setNombre(txtNombre.Text);
                    bebida.setPrecio(Double.Parse(txtPrecio.Text));
                    bebida.setPresentacion(txtPresentacion.Text);
                    bebida.setCantidad(Convert.ToInt32(txtCantidad.Text));
                    MessageBox.Show("El producto ha sido modificado correctamente");

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
