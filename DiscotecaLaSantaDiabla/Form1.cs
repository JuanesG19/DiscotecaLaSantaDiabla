using DiscotecaLaSantaDiabla.logica;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnZonaEspecial_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasEspecial += ingreso;

            try
            {
                AccederZona.reservarZonaEspecial();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZonaA_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasA += ingreso;
        }

        private void btnZonaB_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasB += ingreso;
        }

        private void btnZonaC_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasC += ingreso;
        }

        private void btnZonaD_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasD += ingreso;
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            int ingreso = AccederZona.getIngreso();
            AccederZona.reservasVIP += ingreso;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GUIUsuario usuario = new GUIUsuario();
            usuario.Show();
        }
    }
}
