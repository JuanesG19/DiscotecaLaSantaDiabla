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
    public partial class GUISalidaDeZona : Form
    {
        public GUISalidaDeZona()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(comboZonas.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }

            string zona = comboZonas.Text;
            try
            {
                int usuarios = Convert.ToInt32(txtPersonas.Text);
                Reservas.setSalidaZona(usuarios);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }
           

            switch (zona)
            {
                case "ZONA ESPECIAL":
                    try
                    {
                        Reservas.salidaZonaEspecial();
                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "ZONA A":

                    try
                    {
                        Reservas.salidaZonaA();
                       
                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "ZONA B":

                    try
                    {
                        Reservas.salidaZonaB();

                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "ZONA C":

                    try
                    {
                        Reservas.salidaZonaC();

                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "ZONA D":

                    try
                    {
                        Reservas.salidaZonaD();

                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "ZONA VIP":

                    try
                    {
                        Reservas.salidaZonaVIP();

                        MessageBox.Show("Se Ha Registrado La Salida De Los Usuarios !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;
            }

            this.Close();
        }
    }
}
