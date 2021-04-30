using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DiscotecaLaSantaDiabla.logica;


namespace DiscotecaLaSantaDiabla.graphics.guiBebidas
{
    public partial class GUIBuscarBebida : Form
    {
        public GUIBuscarBebida()
        {
            InitializeComponent();
        }
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIdentificador.Text);

            try
            {
                Producto buscada = Bebida.buscarBebida(id);

                txtNombre.Text = buscada.getNombre();
                txtPrecio.Text = Convert.ToString(buscada.getPrecio());
                txtPresentacion.Text = buscada.getPresentacion();
                txtCantidad.Text = Convert.ToString(buscada.getCantidad());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
