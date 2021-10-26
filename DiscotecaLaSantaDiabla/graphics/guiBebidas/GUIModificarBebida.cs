using DiscotecaLaSantaDiabla.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static DiscotecaLaSantaDiabla.logica.Membresia;
using DiscotecaLaSantaDiabla.baseDeDatos;


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
        String id;
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            id = txtIdentificadorB.Text;
            bebida = BaseDeDatosBebida.buscarBebidaBd(id);

            if (bebida == null)
            {
                MessageBox.Show("No existe la bebida buscada");
                return;
            }            
                
                busqueda = true;
                txtNombreB.Text = bebida.getNombre();
                txtPrecioB.Text = Convert.ToString(bebida.getPrecio().ToString("N", CultureInfo.CurrentCulture));
                txtPresentacionB.Text = bebida.getPresentacion();
                txtCantidadB.Text = Convert.ToString(bebida.getCantidad());
                txtTipoBebidaB.Text = Convert.ToString(bebida.getTipoBebida());

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            id = txtIdentificadorB.Text;
            bebida = BaseDeDatosBebida.buscarBebidaBd(id);

            if (busqueda == true)
            {              

                if (txtNombre.Text.Length == 0  )
                {
                    txtNombre.Text = txtNombreB.Text;
                }
                if(txtPrecio.Text.Length == 0)
                {
                    txtPrecio.Text = txtPrecioB.Text; 
                }
                if (txtPresentacion.Text.Length == 0)
                {
                    txtPresentacion.Text = txtPresentacionB.Text;
                }
                if (txtCantidad.Text.Length == 0)
                {
                    txtCantidad.Text = txtCantidadB.Text;
                }
                if (txtTipoBebidaNew.Text.Length == 0)
                {
                    txtTipoBebidaNew.Text = txtTipoBebidaB.Text;
                }

                try
                {
                    String id = txtIdentificadorB.Text;
                    String nombre = txtNombre.Text;
                    double precio = Double.Parse(txtPrecio.Text);
                    String presentacion = txtPresentacion.Text;
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    String membresia = Convert.ToString(Membresia.Membresias.STANDAR);

                    if (txtTipoBebidaNew.Text.Equals("STANDAR") == true)
                    {
                        membresia = Convert.ToString(Membresia.Membresias.STANDAR);
                    }
                    else if (txtTipoBebidaNew.Text.Equals("VIP") == true)
                    {
                        membresia = Convert.ToString(Membresia.Membresias.VIP);
                    }
                    else
                    {
                        MessageBox.Show("Error De Membresia");
                    }

                    BaseDeDatosBebida.modificarBebida(id,nombre,precio,presentacion,cantidad, membresia);
                    this.Close();
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void formatoMoneda(TextBox txt)
        {
            try
            {
                
                if(txt.Text.Length <=3)
                {
                    MessageBox.Show("Digite un valor numerico correcto para el precio");
                    txt.Text = "";
                    return;
                }
                else
                {
                    int monto;
                    monto = Convert.ToInt32(txt.Text);
                    txt.Text = monto.ToString("N0");
                }

            }
            catch
            {
                MessageBox.Show("Digite un valor numerico correcto para el precio");
                txt.Text = "";
            }
           
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            formatoMoneda(txtPrecio);
        }
    }
}
