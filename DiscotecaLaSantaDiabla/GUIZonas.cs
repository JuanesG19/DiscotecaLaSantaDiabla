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
        private  int numPersonas;

        public  int getNumPersonas()
        {
            return numPersonas;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String zona = Form1.getZona();
            numPersonas = Convert.ToInt32(txtIngreso.Text);

           
            AccederZona.setIngreso(numPersonas);

            switch (zona)
            {
                case "E":
                    try
                    {
                        AccederZona.reservarZonaEspecial();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }

            MessageBox.Show("Prueba");
            this.Close();
        }
    }
}
