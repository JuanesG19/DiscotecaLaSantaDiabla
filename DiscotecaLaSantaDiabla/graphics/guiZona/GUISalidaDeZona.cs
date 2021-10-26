using DiscotecaLaSantaDiabla.baseDeDatos;
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

        int zonaId = 0;

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (comboZonas.Text.Length == 0)
            {
                MessageBox.Show("Debe seleccionar una zona !");
                return;
            }

            string zona = comboZonas.Text;
            int usuarios;

            try
            {
                usuarios = Convert.ToInt32(txtPersonas.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }


            switch (zona)
            {
                case "ZONA ESPECIAL":
                    zonaId = 1;
                    break;

                case "ZONA A":
                    zonaId = 2;
                    break;

                case "ZONA B":
                    zonaId = 3;

                    break;

                case "ZONA C":
                    zonaId = 4;

                    break;

                case "ZONA D":
                    zonaId = 5;
                    break;

                case "ZONA VIP":
                    zonaId = 6;
                    break;
            }

            BaseDeDatosZonas.salidaZonaBd(zonaId, usuarios);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
