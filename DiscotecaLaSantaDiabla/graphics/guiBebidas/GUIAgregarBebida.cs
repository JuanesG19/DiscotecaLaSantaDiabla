using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.baseDeDatos;
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

            Membresia.Membresias tipoBebida;

            if (!txtTipoBebida.Text.Equals("VIP") && !txtTipoBebida.Text.Equals("STANDAR"))
            {
                MessageBox.Show("El tipo de la cuenta no es valido");
                return;
            }
            else if (txtTipoBebida.Text.Equals("STANDAR"))
            {
                tipoBebida = Membresia.Membresias.STANDAR;
            }
            else
            {
                tipoBebida = Membresia.Membresias.VIP;
            }

            try
            {
                String id = txtIdentificador.Text;
                String nombre = txtNombre.Text;
                double precio = Double.Parse(txtPrecio.Text);
                String presentacion = txtPresentacion.Text;
                int cantidad = Int32.Parse(txtCantidad.Text);

                Producto existe = BaseDeDatosBebida.buscarBebidaBd(id);

                if (existe == null)
                {
                    try
                    {
                        BaseDeDatosBebida.agregarBebida(id, nombre, precio, presentacion, cantidad, Convert.ToString(tipoBebida));

                        MessageBox.Show("La bebida : " + nombre + ", Ha sido Agregada con exito");

                        txtIdentificador.Text = " ";
                        txtNombre.Text = " ";
                        txtPrecio.Text = " ";
                        txtPresentacion.Text = " ";
                        txtCantidad.Text = " ";
                        txtTipoBebida.Text = " ";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("La bebida con el id: " + id + ", ya existe");
                }



            }
            catch
            {
                MessageBox.Show("Alguno de los campos ingresados no son validos. \n" +
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

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            GUIModificarBebida.formatoMoneda(txtPrecio);
        }
    }
}
