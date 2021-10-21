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
    public partial class GUIAforoZonas : Form
    {
        public GUIAforoZonas()
        {
            InitializeComponent();
        }

        private void btnConstular_Click(object sender, EventArgs e)
        {
            txtZonaA.Text = Convert.ToString(Reservas.getNumReservasA()) + " de 30";
            txtZonaB.Text = Convert.ToString(Reservas.getNumReservasB()) + " de 30";
            txtZonaC.Text = Convert.ToString(Reservas.getNumReservasC()) + " de 30";
            txtZonaD.Text = Convert.ToString(Reservas.getNumReservasD()) + " de 30";
            txtZonaEspecial.Text = Convert.ToString(Reservas.getNumReservasEspecial()) + " de 60";
            txtZonaVIP.Text = Convert.ToString(Reservas.getNumReservasVIP() + " de 60");
        }
    }
}
