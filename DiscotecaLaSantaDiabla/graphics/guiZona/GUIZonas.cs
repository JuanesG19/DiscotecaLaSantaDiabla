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

            String idUsuario = txtIdentificacionUsuario.Text;
            if(idUsuario.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido para la identificacion del usuario");
                return;
            }
            Cliente user = Usuario.buscarUsuario(idUsuario);
            if (user == null)
            {
                MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                DialogResult dR = MessageBox.Show("El usuario con la identificacion: " + idUsuario + " No existe, ¿Desea crearlo?", "Crear Usuario", botonesConf);
                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                return;
            }

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
                        MessageBox.Show("Se han ingresado los clientes!");
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
                        MessageBox.Show("Se han ingresado los clientes!");
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
                        MessageBox.Show("Se han ingresado los clientes!");
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
                        MessageBox.Show("Se han ingresado los clientes!");
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
                        MessageBox.Show("Se han ingresado los clientes!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case "V":

                    try
                    {
                        if (user.getTipoCuenta().Equals("VIP"))
                        {
                            AccederZona.reservarZonaVIP();
                            MessageBox.Show("Se han ingresado los clientes!");
                        }
                        else
                        {
                            MessageBox.Show("El cliente "+user.getNombre()+" No puede ingresar a esta zona porque no es VIP");
                        }                      
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
