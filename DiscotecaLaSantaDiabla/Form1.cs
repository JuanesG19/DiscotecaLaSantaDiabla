using DiscotecaLaSantaDiabla.logica;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public void btnZonaEspecial_Click(object sender, EventArgs e)
        {
           if(AccederZona.getTopeZonaEspecial() == true)
            {
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialRojo.png");
                btnZonaEspecial.Enabled = false;
            }
            else
            {
                zona = "E";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
        }

        private void btnZonaA_Click(object sender, EventArgs e)
        {
            if (AccederZona.getTopeZonaA() == true)
            {
                btnZonaA.BackgroundImage = Image.FromFile(@"imagenes\ZonaARojo.png");
                btnZonaA.Enabled = false;
            }
            else
            {
                zona = "A";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
                

            
        }

        private void btnZonaB_Click(object sender, EventArgs e)
        {
            if (AccederZona.getTopeZonaB() == true)
            {
                btnZonaB.BackgroundImage = Image.FromFile(@"imagenes\ZonaBRojo.png");
                btnZonaB.Enabled = false;
            }
            else
            {
                zona = "B";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
        }

        private void btnZonaC_Click(object sender, EventArgs e)
        {
            if (AccederZona.getTopeZonaC() == true)
            {
                btnZonaC.BackgroundImage = Image.FromFile(@"imagenes\ZonaCRojo.png");
                btnZonaC.Enabled = false;
            }
            else
            {
                zona = "C";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
        }

        private void btnZonaD_Click(object sender, EventArgs e)
        {
            if (AccederZona.getTopeZonaD() == true)
            {
                btnZonaD.BackgroundImage = Image.FromFile(@"imagenes\ZonaDRojo.png");
                btnZonaD.Enabled = false;
            }
            else
            {
                zona = "D";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            if (AccederZona.getTopeZonaVIP() == true)
            {
                btnVIP.BackgroundImage = Image.FromFile(@"imagenes\ZonaVIPRojo.png");
                btnVIP.Enabled = false;
            }
            else
            {
                zona = "V";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            GUIUsuario usuario = new GUIUsuario();
            usuario.Show();
        }

        private void aforoZonas_Click(object sender, EventArgs e)
        {
            GUIAforoZonas aforo = new GUIAforoZonas();
            aforo.Show();
        }

        private void btnAfotoPorcentual_Click(object sender, EventArgs e)
        {
            double aforo = AccederZona.darAforoTotal();
            MessageBox.Show("El Aforo en la discoteca es del: " + aforo + "%", "Aforo Porcentual");
        }
    }
}
