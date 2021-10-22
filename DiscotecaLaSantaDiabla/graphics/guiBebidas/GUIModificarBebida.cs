using DiscotecaLaSantaDiabla.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DiscotecaLaSantaDiabla.logica.Cuenta;

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
            int id = -1;
            try
            {
                id = Int32.Parse(txtIdentificadorB.Text);
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
                bebida = Bebida.buscarBebida(id);
                busqueda = true;
                txtNombreB.Text = bebida.getNombre();
                txtPrecioB.Text = Convert.ToString(bebida.getPrecio());
                txtPresentacionB.Text = bebida.getPresentacion();
                txtCantidadB.Text = Convert.ToString(bebida.getCantidad());
                txtTipoBebidaB.Text = Convert.ToString(buscada.getTipoBebida());

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

             Cuentas tipoCuenta = Cuentas.STANDAR;

            if (busqueda == true)
            {

                int id = Int32.Parse(txtIdentificadorB.Text);

                bebida = Bebida.buscarBebida(id);


                if (txtNombre.Text.Length == 0 || txtPrecio.Text.Length == 0 || txtPresentacion.Text.Length == 0 || txtCantidad.Text.Length == 0)
                {
                    MessageBox.Show("Hay espacios vacios, No se ha podido modificar la bebida");
                    return;
                }
           
                try
                {

                    if (txtTipoBebidaNew.Text.Equals("STANDAR") == true)
                    {
                        bebida.setTipoBebida(Cuentas.STANDAR);
                        bebida.setNombre(txtNombre.Text);
                        bebida.setPrecio(Double.Parse(txtPrecio.Text));
                        bebida.setPresentacion(txtPresentacion.Text);
                        bebida.setCantidad(Convert.ToInt32(txtCantidad.Text));
                        MessageBox.Show("El producto ha sido modificado correctamente");
                        this.Close();
                    }
                    else if (txtTipoBebidaNew.Text.Equals("VIP") == true)
                    {
                        bebida.setTipoBebida(Cuentas.VIP);
                        bebida.setNombre(txtNombre.Text);
                        bebida.setPrecio(Double.Parse(txtPrecio.Text));
                        bebida.setPresentacion(txtPresentacion.Text);
                        bebida.setCantidad(Convert.ToInt32(txtCantidad.Text));
                        MessageBox.Show("El producto ha sido modificado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error De Membresia");
                    }

                }                    
                 catch
                {
                        MessageBox.Show("Alguno de los campos ingresados no es valido. \n" +
                        "Posibles errores en la digitacion de:  \n" +
                        "Identificador, Precio, Cantidad");
                }
            }
            else
            {
                MessageBox.Show("Es necesario realizar primeramente una busqueda de la bebida a modificar");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
