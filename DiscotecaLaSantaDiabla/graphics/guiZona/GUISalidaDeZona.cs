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
            string zona = comboZonas.Text;
            int usuarios = Convert.ToInt32(txtPersonas.Text);
            AccederZona.setSalidaZona(usuarios);

            switch (zona)
            {
                case "ZONA ESPECIAL":
                    try
                    {
                        AccederZona.salidaZonaEspecial();
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
                        AccederZona.salidaZonaA();
                       
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
                        AccederZona.salidaZonaB();

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
                        AccederZona.salidaZonaC();

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
                        AccederZona.salidaZonaD();

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
                        AccederZona.salidaZonaVIP();

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
