using DiscotecaLaSantaDiabla.graphics.guiUsuario;
using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using DiscotecaLaSantaDiabla.baseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiscotecaLaSantaDiabla
{
    public partial class GUIUsuario : Form
    {
        public GUIUsuario()
        {
            InitializeComponent();

        }

        List<Cliente> clientes;

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            GUIAgregar agregar = new GUIAgregar();
            agregar.Show();
        }

        List<Cliente> usuarios;

        /**
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                gridUsuarios.DataSource = ConexionBaseDeDatos.mostrarUsuario().Tables[0];
                Cliente cliente = 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al mostrar los datos" + ex.Message);
            }
            
        }
        */

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            GUIBuscarUsuario buscar = new GUIBuscarUsuario();
            buscar.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            GUIEliminarUsuario eliminar = new GUIEliminarUsuario();
            eliminar.Show();
        }

        private void btnContarUsuario_Click(object sender, EventArgs e)
        {
            BaseDeDatosUsuario.crearListaBd();
            MessageBox.Show("Hay: " + Usuario.contarUsuarios() + " usuarios registrados", "Contar Usuario");
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            GUIModificarUsuario usuario = new GUIModificarUsuario();
            usuario.Show();
        }

        private void btnModificarMembresia_Click(object sender, EventArgs e)
        {
            GUIMembresia membresia = new GUIMembresia();
            membresia.Show();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            int numFila;

            BaseDeDatosUsuario.crearListaVIPBd();

            clientes = Usuario.getUsuarios();

            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay usuarios VIP registrados");
                return;
            }

            gridUsuarios.Rows.Clear();


            foreach (Cliente user in clientes)
            {
                numFila = gridUsuarios.Rows.Add();

                gridUsuarios.Rows[numFila].Cells[0].Value = user.getID();
                gridUsuarios.Rows[numFila].Cells[1].Value = user.getNombre();
                gridUsuarios.Rows[numFila].Cells[2].Value = user.getApellido();
                gridUsuarios.Rows[numFila].Cells[3].Value = user.getFechaN();
                gridUsuarios.Rows[numFila].Cells[4].Value = user.getTelefono();
                gridUsuarios.Rows[numFila].Cells[5].Value = user.getTipoCuenta();
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

           int numFila;

           BaseDeDatosUsuario.crearListaBd();

           clientes = Usuario.getUsuarios();

            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados");
                gridUsuarios.Rows.Clear();
                return;
            }

            gridUsuarios.Rows.Clear();
    

            foreach (Cliente user in clientes)
            {
                numFila = gridUsuarios.Rows.Add();

                gridUsuarios.Rows[numFila].Cells[0].Value = user.getID();
                gridUsuarios.Rows[numFila].Cells[1].Value = user.getNombre();
                gridUsuarios.Rows[numFila].Cells[2].Value = user.getApellido();
                gridUsuarios.Rows[numFila].Cells[3].Value = user.getFechaN();
                gridUsuarios.Rows[numFila].Cells[4].Value = user.getTelefono();
                gridUsuarios.Rows[numFila].Cells[5].Value = user.getTipoCuenta();
            
            }
            
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
