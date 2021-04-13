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
    public partial class GUIUsuario : Form
    {
        public GUIUsuario()
        {
            InitializeComponent();

        }

        private void GUIUsuario_Load(object sender, EventArgs e)
        {
       
           
        }

        private void gridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            GUIAgregar agregar = new GUIAgregar();
            agregar.Show();
        }

        List<Cliente> usuarios;

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numFila;
            int iter = 0;

            usuarios = Usuario.getUsuarios();

            gridUsuarios.Rows.Clear();

            foreach (Cliente cliente in usuarios)
            {
                numFila = gridUsuarios.Rows.Add();
                iter++;

                gridUsuarios.Rows[numFila].Cells[0].Value = iter;
                gridUsuarios.Rows[numFila].Cells[1].Value = cliente.getID();
                gridUsuarios.Rows[numFila].Cells[2].Value = cliente.getNombre();
                gridUsuarios.Rows[numFila].Cells[3].Value = cliente.getApellido();
                gridUsuarios.Rows[numFila].Cells[4].Value = cliente.getTipoCuenta();
                gridUsuarios.Rows[numFila].Cells[5].Value = cliente.getTelefono();
                gridUsuarios.Rows[numFila].Cells[6].Value = cliente.getgetFechaN();

            }
        }
    }
}
