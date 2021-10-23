using DiscotecaLaSantaDiabla.graphics.guiUsuario;
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
            String zona = GUIPrincipal.getZona();

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
                Reservas.setIngreso(numPersonas); 
                
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
                        Reservas.reservarZonaEspecial();
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
                        Reservas.reservarZonaA();
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
                        Reservas.reservarZonaB();
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
                        Reservas.reservarZonaC();
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
                        Reservas.reservarZonaD();
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
                        if (user.getTipoCuenta().Equals(Cuenta.Cuentas.VIP))
                        {
                            Reservas.reservarZonaVIP();
                            MessageBox.Show("Se han ingresado los clientes!");
                        }
                        else
                        {
                            MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                            DialogResult dR = MessageBox.Show("Acceso a zona VIP restringido. El usuario no cuenta con membresia VIP ¿Desea actualizar su membresia a VIP?", "Actualizar Membresia", botonesConf);

                            if (dR == DialogResult.Yes)
                            {
                                GUIMembresia agregar = new GUIMembresia();
                                agregar.Show();
                            }
                            else if(dR == DialogResult.No)
                            {
                                return;
                            }
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
