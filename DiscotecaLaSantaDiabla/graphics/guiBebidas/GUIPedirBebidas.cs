using DiscotecaLaSantaDiabla.graphics.guiUsuario;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
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
            String idBebida = "";
            int cantidad = 0;

            try
            {
                idBebida = txtIdentificador.Text;
                cantidad = Int32.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor valido");
            }

            String idUsuario = txtIdentificacionUsuario.Text;

            if (idUsuario.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido para la identificacion del usuario");
                return;
            }

            Cliente user = BaseDeDatosUsuario.buscarClienteBd(idUsuario);

            if (user == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("El usuario con la identificacion: " + idUsuario + " No existe, ¿Desea crearlo?", "Crear Usuario", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                else
                {
                    return;
                }
                return;
            }

            Producto buscada = BaseDeDatosBebida.buscarBebidaBd(idBebida);

            if (buscada == null)
            {
                MessageBoxButtons botonesBeb = MessageBoxButtons.YesNo;
                DialogResult dbeb = MessageBox.Show("La bebida buscada con el id: " + idBebida + " No existe, ¿Desea crearla?", "Crear Bebida", botonesBeb);

                if (dbeb == DialogResult.Yes)
                {
                    GUIAgregarBebida agregar = new GUIAgregarBebida();
                    agregar.Show();
                }
                else
                {
                    return;
                }
            }

            if (buscada.getTipoBebida().Equals(logica.Membresia.Membresias.VIP) && user.getTipoCuenta().Equals(logica.Membresia.Membresias.STANDAR))
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("Bebida unicamente para clientes VIP. ¿Desea actualizar su membresia a VIP?", "Actualizar Membresia", botonesConf);

                if (dR == DialogResult.Yes)
                {
                    GUIMembresia agregar = new GUIMembresia();
                    agregar.Show();
                }
                else if (dR == DialogResult.No)
                {
                    return;
                }

                return;
            }
            try
            {
                BaseDeDatosBebida.pedirBebidaBd(idBebida, cantidad, user.getID());

                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo pedir la bebida Error!");
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            int idFactura = BaseDeDatosFactura.obtenerValorUltimaFactura();
            Factura factura = BaseDeDatosFactura.crearFactura(idFactura);
            Facturacion.generarFactura(factura);
        }
    }
}
