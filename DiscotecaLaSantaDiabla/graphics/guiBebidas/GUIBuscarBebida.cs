using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            int id = -1;
            try
            {
                id = Int32.Parse(txtIdentificador.Text);
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
                txtNombre.Text = buscada.getNombre();
                txtPrecio.Text = Convert.ToString(buscada.getPrecio().ToString("C", CultureInfo.CurrentCulture));
                txtPresentacion.Text = buscada.getPresentacion();
                txtCantidad.Text = Convert.ToString(buscada.getCantidad());
                txtTipoBebida.Text = Convert.ToString(buscada.getTipoBebida());
        }
    }
}
