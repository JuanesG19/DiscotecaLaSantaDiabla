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
    public partial class GUIAgregarBebida : Form
    {
        public GUIAgregarBebida()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIdentificador.Text);
            String nombre = txtNombre.Text;
            double precio = Double.Parse(txtPrecio.Text);
            String presentacion = txtPresentacion.Text;
            int cantidad = Int32.Parse(txtCantidad.Text);

            Producto producto = new Producto(id, nombre, precio, presentacion, cantidad);
            try
            {
                logica.Bebida.agregarBebida(producto);
                MessageBox.Show(producto.getNombre() + ", Ha sido registrado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
