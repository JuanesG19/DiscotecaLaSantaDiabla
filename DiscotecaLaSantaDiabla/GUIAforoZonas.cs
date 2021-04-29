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
            txtZonaA.Text = Convert.ToString(AccederZona.darNumReservasA());
            txtZonaB.Text = Convert.ToString(AccederZona.darNumReservasB());
            txtZonaC.Text = Convert.ToString(AccederZona.darNumReservasC());
            txtZonaD.Text = Convert.ToString(AccederZona.darNumReservasD());
            txtZonaEspecial.Text = Convert.ToString(AccederZona.darNumReservasEspecial());
            txtZonaVIP.Text = Convert.ToString(AccederZona.darNumReservasVIP());
        }
    }
}
