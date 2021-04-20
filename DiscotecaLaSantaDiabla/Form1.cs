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

        private static String zona = "";

        public static String getZona()
        {
            return zona;
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
            zona = "E";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();          
        }

        private void btnZonaA_Click(object sender, EventArgs e)
        {
            zona = "A";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();

            
        }

        private void btnZonaB_Click(object sender, EventArgs e)
        {
            zona = "B";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();
        }

        private void btnZonaC_Click(object sender, EventArgs e)
        {
            zona = "C";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();
        }

        private void btnZonaD_Click(object sender, EventArgs e)
        {
            zona = "D";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            zona = "V";
            GUIZonas zonas = new GUIZonas();
            zonas.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GUIUsuario usuario = new GUIUsuario();
            usuario.Show();
        }
    }
}
