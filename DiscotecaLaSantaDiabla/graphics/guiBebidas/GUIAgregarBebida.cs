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
                MessageBox.Show("Hay espacios vacios, No se ha podido agregar la bebida");
                return;
            }

            Cuenta.Cuentas tipoBebida;

            if (!txtTipoBebida.Text.Equals("VIP") && !txtTipoBebida.Text.Equals("STANDAR"))
            {
                MessageBox.Show("El tipo de la cuenta no es valido");
                return;
            }
            else if (txtTipoBebida.Text.Equals("STANDAR"))
            {
                tipoBebida = Cuenta.Cuentas.STANDAR;
            }
            else
            {
                tipoBebida = Cuenta.Cuentas.VIP;
            }

            try
            {
                int id = Int32.Parse(txtIdentificador.Text);
                String nombre = txtNombre.Text;
                double precio = Double.Parse(txtPrecio.Text);
                String presentacion = txtPresentacion.Text;
                int cantidad = Int32.Parse(txtCantidad.Text);

                Producto producto = new Producto(id, nombre, precio, presentacion, cantidad, tipoBebida);
                
                try
                {
                    Bebida.agregarBebida(producto);
                    MessageBox.Show(producto.getNombre() + ", Ha sido registrado con exito");
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

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
