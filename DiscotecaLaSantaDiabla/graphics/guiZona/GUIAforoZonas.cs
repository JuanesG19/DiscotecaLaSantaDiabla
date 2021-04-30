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
            txtZonaA.Text = Convert.ToString(AccederZona.darNumReservasA()) + " de 30";
            txtZonaB.Text = Convert.ToString(AccederZona.darNumReservasB()) + " de 30";
            txtZonaC.Text = Convert.ToString(AccederZona.darNumReservasC()) + " de 30";
            txtZonaD.Text = Convert.ToString(AccederZona.darNumReservasD()) + " de 30";
            txtZonaEspecial.Text = Convert.ToString(AccederZona.darNumReservasEspecial()) + " de 60";
            txtZonaVIP.Text = Convert.ToString(AccederZona.darNumReservasVIP() + " de 60");
        }
    }
}
