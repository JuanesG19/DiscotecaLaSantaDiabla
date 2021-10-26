using DiscotecaLaSantaDiabla.graphics.guiBebidas;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.baseDeDatos;
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
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private static int idZona;

        public static int getZona()
        {
            return idZona;
        }

        GUIZonas zonas = new GUIZonas();

        private void btnZonaEspecial_Click(object sender, EventArgs e)
        {
            Zona zona = BaseDeDatosZonas.buscarZonaBd(1);

            if (zona.getCapacidaActual() < 60 )
            {
                btnZonaEspecial.BackgroundImage = Image.FromFile(@"imagenes\ZonaEspecialVerde.png");
                idZona = 1;
                GUIZonas zonas = new GUIZonas();
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
            Zona zona = BaseDeDatosZonas.buscarZonaBd(2);

            if (zona.getCapacidaActual()  < 30)
            {
                btnZonaA.BackgroundImage = Image.FromFile(@"imagenes\ZonaAVerde.png");
                idZona = 2;
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
            Zona zona = BaseDeDatosZonas.buscarZonaBd(3);

            if (zona.getCapacidaActual() < 30)
            {
                btnZonaB.BackgroundImage = Image.FromFile(@"imagenes\ZonaBVerde.png");
                idZona = 3;
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
            Zona zona = BaseDeDatosZonas.buscarZonaBd(4);

            if (zona.getCapacidaActual() < 30)
            {
                btnZonaC.BackgroundImage = Image.FromFile(@"imagenes\ZonaCVerde.png");
                idZona = 4;
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
            Zona zona = BaseDeDatosZonas.buscarZonaBd(5);

            if (zona.getCapacidaActual() < 30)
            {
                btnZonaD.BackgroundImage = Image.FromFile(@"imagenes\ZonaDVerde.png");
                idZona = 5;
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
            Zona zona = BaseDeDatosZonas.buscarZonaBd(6);

            if (zona.getCapacidaActual() < 60)
            {
                btnVIP.BackgroundImage = Image.FromFile(@"imagenes\ZonaVIPVerde.png");
                idZona = 6;
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

        private static int darAforototal()
        {
            int capacidad = BaseDeDatosZonas.buscarZonaBd(1).getCapacidaActual() +
            BaseDeDatosZonas.buscarZonaBd(2).getCapacidaActual() +
            BaseDeDatosZonas.buscarZonaBd(3).getCapacidaActual() +
            BaseDeDatosZonas.buscarZonaBd(4).getCapacidaActual() +
            BaseDeDatosZonas.buscarZonaBd(5).getCapacidaActual() +
            BaseDeDatosZonas.buscarZonaBd(6).getCapacidaActual();

            int capacidadMaxima = 240;

            int aforo = (capacidad * 100) / capacidadMaxima;
            return aforo;
        }



        private void btnAfotoPorcentual_Click(object sender, EventArgs e)
        {
            int aforo = darAforototal();
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

        private void btnPruebaBaseDeDatos_Click(object sender, EventArgs e)
        {
            ConexionBaseDeDatos.establecerConexion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConexionBaseDeDatos.cerrarConexion();
        }

        private void GUIPrincipal_Load(object sender, EventArgs e)
        {
            ConexionBaseDeDatos.establecerConexion();
            ConexionBaseDeDatos.cerrarConexion();
        }
    }
}
