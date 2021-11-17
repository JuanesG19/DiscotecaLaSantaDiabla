using DiscotecaLaSantaDiabla.baseDeDatos;
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
            int zona = GUIPrincipal.getZona();

            String idUsuario = txtIdentificacionUsuario.Text;

            if (idUsuario.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido para la identificacion del usuario");
                return;
            }
            else
            {
                Cliente user = BaseDeDatosUsuario.buscarClienteBd(idUsuario);
                try
                {
                    numPersonas = Convert.ToInt32(txtIngreso.Text);

                }
                catch
                {
                    MessageBox.Show("El valor ingresado no es correcto");
                }

                BaseDeDatosZonas.modificarCapacidadBd(zona, numPersonas, user.getID());


                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
