using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.baseDeDatos;



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
            String id = txtIdentificador.Text;

            Producto bebida = BaseDeDatosBebida.buscarBebidaBd(id);

            if (bebida == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("La bebida que desea buscar no se encuentra registrado ¿Desea registrarla?", "Bebida no encontrada", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIAgregarBebida agregar = new GUIAgregarBebida();
                    agregar.Show();
                }
                else if (dR == DialogResult.No)
                {
                    this.Close();
                }

            }
            else
            {
                txtNombre.Text = bebida.getNombre();
                txtPrecio.Text = Convert.ToString(bebida.getPrecio().ToString("C", CultureInfo.CurrentCulture));
                txtPresentacion.Text = bebida.getPresentacion();
                txtCantidad.Text = Convert.ToString(bebida.getCantidad());
                txtTipoBebida.Text = Convert.ToString(bebida.getTipoBebida());
            }
        }
    }
}
