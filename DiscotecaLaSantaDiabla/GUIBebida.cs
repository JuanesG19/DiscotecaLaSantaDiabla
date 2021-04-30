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
        Bebida bebida = new Bebida();


        public GUIBebida()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numFila;
            int iter = 0;

            bebidas = bebida.darBebidas();
            bebidas.AddRange(bebida.darBebidasEspeciales());

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
    }
}
