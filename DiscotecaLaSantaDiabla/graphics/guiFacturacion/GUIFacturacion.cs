using DiscotecaLaSantaDiabla.baseDeDatos;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DiscotecaLaSantaDiabla.logica.Membresia;

namespace DiscotecaLaSantaDiabla.graphics.guiUsuario
{
    public partial class GUIFacturacion : Form
    {
        public GUIFacturacion()
        {
            InitializeComponent();
        }

        List<Factura> facturas;

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarUsuariosVIP();
        }

        public void mostrarUsuariosVIP()
        {
            int numFila;
            int iter = 0;

            BaseDeDatosFactura.listaFacturasBd();
            facturas = Factura.getFacturas();

            gridFacturas.Rows.Clear();

            if (facturas.Count == 0)
            {
                MessageBox.Show("No hay facturas registrados");
            }

            foreach (Factura factura in facturas)
            {
                
                    numFila = gridFacturas.Rows.Add();

                    gridFacturas.Rows[numFila].Cells[0].Value = Convert.ToString(factura.getIdFactura());
                    gridFacturas.Rows[numFila].Cells[1].Value = Convert.ToString(factura.getIdUsuario());
                    gridFacturas.Rows[numFila].Cells[2].Value = factura.getNombreUsuario();
                    gridFacturas.Rows[numFila].Cells[3].Value = factura.getApellidoUsuario();
                    gridFacturas.Rows[numFila].Cells[4].Value = factura.getTelefonoUsuario();
                    gridFacturas.Rows[numFila].Cells[5].Value = factura.getNombreBebida();
                    gridFacturas.Rows[numFila].Cells[6].Value = Convert.ToString(factura.getCantidadBebida());
                    gridFacturas.Rows[numFila].Cells[7].Value = Convert.ToString(factura.getPrecioSubtotal());
                    gridFacturas.Rows[numFila].Cells[8].Value = Convert.ToString(factura.getPrecioTotal());
                    gridFacturas.Rows[numFila].Cells[9].Value = factura.getFechaFactura();
            }

        }
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            String idGrid = null;
            try
            {
                idGrid = gridFacturas.CurrentCell.Value.ToString();
            }
            catch
            {
                MessageBox.Show("Seleccione una celda valida");
                return;
            }

            int idFactura;
            bool validador = int.TryParse(idGrid, out idFactura);

            if(validador == false)
            {
                MessageBox.Show("Seleccione un numero de factura valido");
                return;
            }
            else
            {
                MessageBox.Show("La factura fue impresa");
                Factura factura = BaseDeDatosFactura.crearFactura(idFactura);
                Facturacion.generarFactura(factura);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
