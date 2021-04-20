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

            try
            {
                AccederZona.reservarZonaEspecial();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnZonaA_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            try
            {
                AccederZona.reservarZonaA();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZonaB_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            try
            {
                AccederZona.reservarZonaB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZonaC_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            try
            {
                AccederZona.reservarZonaC();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZonaD_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            try
            {
                AccederZona.reservarZonaD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            try
            {
                AccederZona.reservarZonaPalco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GUIUsuario usuario = new GUIUsuario();
            usuario.Show();
        }
    }
}
