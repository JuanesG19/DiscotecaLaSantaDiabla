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
            if (txtIdentificador.Text.Length == 0 || txtNombre.Text.Length == 0 || txtPrecio.Text.Length == 0 || txtPresentacion.Text.Length == 0 || txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("Hay espacios vacios, No se ha podido agregar el usuario");
                return;
            }
            try
            {
                int id = Int32.Parse(txtIdentificador.Text);
                String nombre = txtNombre.Text;
                double precio = Double.Parse(txtPrecio.Text);
                String presentacion = txtPresentacion.Text;
                int cantidad = Int32.Parse(txtCantidad.Text);
                Producto producto = new Producto(id, nombre, precio, presentacion, cantidad);
                try
                {
                    Bebida.agregarBebida(producto);
                    MessageBox.Show(producto.getNombre() + ", Ha sido registrado con exito");
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            catch
            {
                MessageBox.Show("Alguno de los campos ingresados no es valido. \n" +
                    "Posibles errores en la digitacion de:  \n" +
                    "Identificador, Precio, Cantidad");
            }                               
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
