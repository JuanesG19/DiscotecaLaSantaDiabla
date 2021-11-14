using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica.usuario
{
    class Usuario
    {
        //ATRIBUTOS 

        //Lista de Clientes
        private static List<Cliente> clientes = new List<Cliente>();


        //METODOS

        //Metodo Get Usuarios
        public static List<Cliente> getUsuarios() => clientes;


        //Metodo Buscar Usuario
        public static Cliente buscarUsuario(String id)
        {
            Cliente buscado = null;
            foreach (Cliente c in clientes)
            {
                if (c.getID().Equals(id))
                {
                    buscado = c;
                    break;
                }
            }
            return buscado;
        }

        //Metodo Crear Usuario 
        public static void crearUsuario(Cliente pCliente)
        {
            if (buscarUsuario(pCliente.getID()) == null)
            {
                clientes.Add(pCliente);
            }
            else
            {
                throw new Exception("El usuario ya existe, no se pueden agregar dos usuarios con la misma identificacion");
            }

        }       

        //Metodo Contar Usuarios
        public static int contarUsuarios()
        {
            int cantidad = clientes.Count;
            return cantidad;
        }

        public static void limpiarLista()
        {
           for(int i=0; i<clientes.Count;i++)
           {
                clientes.RemoveAt(i);
                i--;
           }
        }
    }
}



