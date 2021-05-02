using DiscotecaLaSantaDiabla.graphics.guiBebidas;
using DiscotecaLaSantaDiabla.logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class GUIBebida : Form
    {

        List<Producto> bebidas = new List<Producto>();
        //Bebida nueva = new Bebida();

        public GUIBebida()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numFila;
            int iter = 0;

            bebidas = Bebida.darBebidas();
           
            gridBebidas.Rows.Clear();

            foreach (Producto b in bebidas)
            {
                numFila = gridBebidas.Rows.Add();
                iter++;

                gridBebidas.Rows[numFila].Cells[0].Value = iter;
                gridBebidas.Rows[numFila].Cells[1].Value = b.getIdBebida();
                gridBebidas.Rows[numFila].Cells[2].Value = b.getNombre();
                gridBebidas.Rows[numFila].Cells[3].Value = b.getPrecio();
                gridBebidas.Rows[numFila].Cells[4].Value = b.getPresentacion();
                gridBebidas.Rows[numFila].Cells[5].Value = b.getCantidad();
            } 
        }

        private void btnAgregarBebida_Click(object sender, EventArgs e)
        {
            GUIAgregarBebida agregar = new GUIAgregarBebida();
            agregar.Show();
        }

        private void btnEliminarBebida_Click(object sender, EventArgs e)
        {
            GUIEliminarBebida eliminar = new GUIEliminarBebida();
            eliminar.Show();
        }

        private void btnBuscarBebida_Click(object sender, EventArgs e)
        {
            GUIBuscarBebida buscar = new GUIBuscarBebida();
            buscar.Show();
        }
        
        private void btnModificarBebida_Click(object sender, EventArgs e)
        {
            GUIModificarBebida modificar = new GUIModificarBebida();
            modificar.Show();
        }
    }
}
