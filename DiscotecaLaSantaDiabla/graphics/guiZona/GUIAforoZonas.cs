using DiscotecaLaSantaDiabla.baseDeDatos;
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
            txtZonaEspecial.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(1).getCapacidaActual() + " de 60");
            txtZonaA.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(2).getCapacidaActual() + " de 30");
            txtZonaB.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(3).getCapacidaActual() + " de 30");
            txtZonaC.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(4).getCapacidaActual() + " de 30");
            txtZonaD.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(5).getCapacidaActual() + " de 30");
            txtZonaVIP.Text = Convert.ToString(BaseDeDatosZonas.buscarZonaBd(6).getCapacidaActual() + " de 60");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
