using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla.graphics.guiBebidas
{
    public partial class GUIPedirBebidas : Form
    { 
        
        public GUIPedirBebidas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = 0;
            int cantidad = 0;

            try
            {
                id = Int32.Parse(txtIdentificador.Text);
                cantidad = Int32.Parse(txtCantidad.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un valor valido");
            }

            String idUsuario = txtIdentificacionUsuario.Text;
            if (idUsuario.Length == 0)
            {
                MessageBox.Show("Ingrese un valor valido para la identificacion del usuario");
                return;
             }

             Cliente user = Usuario.buscarUsuario(idUsuario);

             if(user == null)
             {
                 MessageBoxButtons botonesConf = MessageBoxButtons.YesNo;
                 DialogResult dR = MessageBox.Show("El usuario con la identificacion: " + idUsuario + " No existe, ¿Desea crearlo?","Crear Usuario", botonesConf);
             
                if (dR == DialogResult.Yes)
                {
                    GUIAgregar agregar = new GUIAgregar();
                    agregar.Show();
                }
                return;
             }

             Producto buscada = Bebida.buscarBebida(id);

             if (buscada == null)
             {
                MessageBoxButtons botonesBeb = MessageBoxButtons.YesNo;
                DialogResult dbeb = MessageBox.Show("La bebida buscada con el id: " + id+ " No existe, ¿Desea crearla?", "Crear Bebida", botonesBeb);

                 if (dbeb == DialogResult.Yes)
                 {
                        GUIAgregarBebida agregar = new GUIAgregarBebida();
                        agregar.Show();
                 }

                 return;
             }

             Bebida.setNumBebidas(cantidad);

             MessageBoxButtons botones = MessageBoxButtons.YesNo;
             DialogResult dr = MessageBox.Show("El total a pagar es : " + Bebida.totalAPagar(id) + "$. Desea adquirir los productos?", "Pagar", botones);

             if (dr == DialogResult.Yes)
             {
                try
                {
                    Bebida.pedirBebida(id);
                    MessageBox.Show("Los productos fueron adquiridos correctamente por el cliente " + user.getNombre()+"!");
                    this.Close();

                }
                    
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
             }    
        }
    }
}
