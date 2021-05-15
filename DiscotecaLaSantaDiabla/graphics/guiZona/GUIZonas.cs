using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class GUIZonas : Form
    {
         
        public GUIZonas()
        {
            InitializeComponent();
        }

        private int numPersonas;
      
        public int getNumPersonas()
        {
            return numPersonas;
        }

        

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String zona = Form1.getZona();

            try
            {
                numPersonas = Convert.ToInt32(txtIngreso.Text);
                AccederZona.setIngreso(numPersonas); 
                
            }
            catch
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }
            

            switch (zona)
            {
                case "E":
                    try
                    {
                        AccederZona.reservarZonaEspecial();
                        MessageBox.Show("Se han ingresado los clientes !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "A":

                    try
                    {
                        AccederZona.reservarZonaA();
                        MessageBox.Show("Se han ingresado los clientes !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "B":

                    try
                    {
                        AccederZona.reservarZonaB();
                        MessageBox.Show("Se han ingresado los clientes !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "C":

                    try
                    {
                        AccederZona.reservarZonaC();
                        MessageBox.Show("Se han ingresado los clientes !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "D":

                    try
                    {
                        AccederZona.reservarZonaD();
                        MessageBox.Show("Se han ingresado los clientes !");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "V":

                    try
                    {
                        AccederZona.reservarZonaVIP();
                        MessageBox.Show("Se han ingresado los clientes !");
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
