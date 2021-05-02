using DiscotecaLaSantaDiabla.graphics.guiBebidas;
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

        private void btnZonaEspecial_Click(object sender, EventArgs e)
        {
            
            if (AccederZona.darNumReservasEspecial() < 60 )
            {
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialVerde.png");
                GUIZonas zonas = new GUIZonas();
                zona = "E";
                zonas.Show();
            }
            else
            {
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialRojo.png");
                MessageBox.Show("La Zona Especial Ya Se Encuentra Al Maximo De Su Capacidad");
            }
        }

        private void btnZonaA_Click(object sender, EventArgs e)
        {
            if (AccederZona.darNumReservasA() < 30)
            {
                btnZonaA.BackgroundImage = Image.FromFile(@"imagenes\ZonaAVerde.png");
                zona = "A";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
            else
            {
                btnZonaA.BackgroundImage = Image.FromFile(@"imagenes\ZonaARojo.png");
                MessageBox.Show("La Zona A Ya Se Encuentra Al Maximo De Su Capacidad");
            } 
        }

        private void btnZonaB_Click(object sender, EventArgs e)
        {
            if (AccederZona.darNumReservasB() < 30)
            {
                btnZonaB.BackgroundImage = Image.FromFile(@"imagenes\ZonaBVerde.png");
                zona = "B";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
            else
            {
                btnZonaB.BackgroundImage = Image.FromFile(@"imagenes\ZonaBRojo.png");
                MessageBox.Show("La Zona B Ya Se Encuentra Al Maximo De Su Capacidad");
            }
        }

        private void btnZonaC_Click(object sender, EventArgs e)
        {
            if (AccederZona.darNumReservasC() < 30)
            {
                btnZonaC.BackgroundImage = Image.FromFile(@"imagenes\ZonaCVerde.png");
                zona = "C";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
            else
            {
                btnZonaC.BackgroundImage = Image.FromFile(@"imagenes\ZonaCRojo.png");
                MessageBox.Show("La Zona C Ya Se Encuentra Al Maximo De Su Capacidad");
            }
        }

        private void btnZonaD_Click(object sender, EventArgs e)
        {
            if (AccederZona.darNumReservasD() < 30)
            {
                btnZonaD.BackgroundImage = Image.FromFile(@"imagenes\ZonaDVerde.png");
                zona = "D";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
            else
            {
                btnZonaD.BackgroundImage = Image.FromFile(@"imagenes\ZonaDRojo.png");
                MessageBox.Show("La Zona D Ya Se Encuentra Al Maximo De Su Capacidad");
            }
        }

        private void btnVIP_Click(object sender, EventArgs e)
        {
            if (AccederZona.darNumReservasVIP() < 60)
            {
                btnVIP.BackgroundImage = Image.FromFile(@"imagenes\ZonaVIPVerde.png");
                zona = "V";
                GUIZonas zonas = new GUIZonas();
                zonas.Show();
            }
            else
            {
                btnVIP.BackgroundImage = Image.FromFile(@"imagenes\ZonaVIPRojo.png");
                MessageBox.Show("La Zona VIP Ya Se Encuentra Al Maximo De Su Capacidad");
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

        public void cambiarEstadoBotonEspecial(bool estado)
        {

            if(estado == true)
            {
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialRojo.png");
                btnZonaEspecial.Enabled = false;
            }
            else
            {     
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialVerde.png");
                btnZonaEspecial.Enabled = true;
            }

        }

        private void btnSalidaDeUsuarios_Click(object sender, EventArgs e)
        {
            GUISalidaDeZona salida = new GUISalidaDeZona();
            salida.Show();
        }

        private void btnInventarioBebidas_Click(object sender, EventArgs e)
        {
            GUIBebida bebida = new GUIBebida();
            bebida.Show();

        }

        private void btnPedirBebidas_Click(object sender, EventArgs e)
        {
            GUIPedirBebidas pedir = new GUIPedirBebidas();
            pedir.Show();
        }
    }
}
