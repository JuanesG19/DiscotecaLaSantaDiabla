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
    public partial class GUIPedirBebidas : Form
    { 
        
        public GUIPedirBebidas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

                int id = Int32.Parse(txtIdentificador.Text);
                int cantidad = Int32.Parse(txtCantidad.Text);

                Bebida.setNumBebidas(cantidad);

                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                DialogResult dr = MessageBox.Show("El total a pagar es : " + Bebida.totalAPagar(id) + "$. Desea adquirir los productos?", "Pagar", botones);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Bebida.pedirBebida(id);
                        MessageBox.Show("Los productos fueron adquiridos correctamente!");
                    }
                    
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }    
        }
    }
}
