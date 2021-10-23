using DiscotecaLaSantaDiabla.logica;
using DiscotecaLaSantaDiabla.logica.usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static DiscotecaLaSantaDiabla.logica.Cuenta;

namespace DiscotecaLaSantaDiabla.graphics.guiUsuario
{
    public partial class GUIMembresiaVIP : Form
    {
        public GUIMembresiaVIP()
        {
            InitializeComponent();
        }

        List<Cliente> usuarios;

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarUsuariosVIP();
        }
        
        public void mostrarUsuariosVIP()
        {
            int numFila;
            int iter = 0;

            usuarios = Usuario.getUsuarios();
            gridUsuarios.Rows.Clear();

            if (usuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios VIP registrados");
            }

            foreach (Cliente cliente in usuarios)
            {
                if (cliente.getTipoCuenta().Equals(Cuentas.VIP))
                {
                    numFila = gridUsuarios.Rows.Add();
                    iter++;

                    DateTime fechaActual = Convert.ToDateTime(cliente.getFechaVencimientoM());
                    DateTime fechaVencimiento = fechaActual.AddMonths(1);

                    gridUsuarios.Rows[numFila].Cells[0].Value = iter;
                    gridUsuarios.Rows[numFila].Cells[1].Value = cliente.getID();
                    gridUsuarios.Rows[numFila].Cells[2].Value = cliente.getNombre();
                    gridUsuarios.Rows[numFila].Cells[3].Value = cliente.getApellido();
                    gridUsuarios.Rows[numFila].Cells[4].Value = cliente.getTelefono();
                    gridUsuarios.Rows[numFila].Cells[5].Value = fechaActual;
                    gridUsuarios.Rows[numFila].Cells[6].Value = fechaVencimiento;


                }

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
