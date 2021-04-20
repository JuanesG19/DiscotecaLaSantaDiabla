using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica.usuario
{
    class Usuario
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> getUsuarios()
        {
          return clientes;
        }     
        //Metodos 
        //Crear Usuario - B
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

        //Modificar - B
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

        //Buscar - B
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

        //Eliminar - B
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

        //Cambiar Estado - B
        public static void cambiarEstado(String id)
        {
            Cliente idBuscado = buscarUsuario(id);
            int pos = clientes.IndexOf(idBuscado);

            if (idBuscado.getTipoCuenta() == Cuenta.Cuentas.STANDAR)
            {
                eliminarUsuario(idBuscado.getID());
                idBuscado.setTipoCuenta(Cuenta.Cuentas.VIP);
                clientes.Insert(pos, idBuscado);

            }
            else if (idBuscado.getTipoCuenta() == Cuenta.Cuentas.VIP)
            {
                eliminarUsuario(idBuscado.getID());
                idBuscado.setTipoCuenta(Cuenta.Cuentas.STANDAR);
                clientes.Insert(pos, idBuscado);
            }
            else
            {
                throw new Exception("El Cliente no tiene un tipo de cuenta definido");
            }

        }

        //Contar Usuarios - B
        public static int contarUsuarios()
        {
            int cantidad = clientes.Count;
            return cantidad;
        }

    }
}



