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

        //Metodo Modificar Usuario
        public static void modificarUsuario(Cliente nuevoCliente, String id)
        {
            Cliente clienteModificar = buscarUsuario(id);
            int pos = clientes.IndexOf(clienteModificar);

            try
            {
                eliminarUsuario(id);
                clientes.Insert(pos, nuevoCliente);
            }
            catch
            {
                throw new Exception("El cliente no ha podido ser modificado!");
            }
        }

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

        //Metodo Eliminar Usuario
        public static void eliminarUsuario(String id)
        {
            Cliente buscado = buscarUsuario(id);

            if (buscado != null)
            {
                int pos = clientes.IndexOf(buscado);
                clientes.RemoveAt(pos);
            }
            else
            {
                throw new Exception("No se pudo eliminar el usuario");
            }
        }

        //Metodo Cambiar Estado
        public static void cambiarEstado(String id)
        {
            Cliente idBuscado = buscarUsuario(id);
            int pos = clientes.IndexOf(idBuscado);

            if (idBuscado.getTipoCuenta() == Membresia.Membresias.STANDAR)
            {
                eliminarUsuario(idBuscado.getID());
                idBuscado.setTipoCuenta(Membresia.Membresias.VIP);
                clientes.Insert(pos, idBuscado);

            }
            else if (idBuscado.getTipoCuenta() == Membresia.Membresias.VIP)
            {
                eliminarUsuario(idBuscado.getID());
                idBuscado.setTipoCuenta(Membresia.Membresias.STANDAR);
                clientes.Insert(pos, idBuscado);
            }
            else
            {
                throw new Exception("El Cliente no tiene un tipo de cuenta definido");
            }
        }

        //Metodo Contar Usuarios
        public static int contarUsuarios()
        {
            int cantidad = clientes.Count;
            return cantidad;
        }

    }
}



