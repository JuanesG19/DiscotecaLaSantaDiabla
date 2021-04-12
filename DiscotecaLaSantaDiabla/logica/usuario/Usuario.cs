using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica.usuario
{
    class Usuario
    {
        private List<Cliente> usuarios;

        public Usuario()
        {
            usuarios = new List<Cliente>();
        }

        public List<Cliente> getUsuarios() => usuarios;

        //Metodos

        //Crear Usuario

        public void crearUsuario(Cliente pCliente)
        {
            if (buscarUsuario(pCliente.getID()) !=1)
            {
                usuarios.Add(pCliente);
            }
            else
            {
                throw new Exception("El usuario a agregar ya existe");
            }
        }

        //Modificar - B

        public void modificarUsuario(Cliente pCliente)
        {
            int idBuscado = buscarUsuario(pCliente.getID());

            if (idBuscado != 1 && usuarios.ElementAt(idBuscado).getID() == pCliente.getID())
            {
                usuarios.ElementAt(idBuscado).setNombre(pCliente.getNombre());
                usuarios.ElementAt(idBuscado).setApellido(pCliente.getApellido());
                usuarios.ElementAt(idBuscado).setTelefono(pCliente.getTelefono());
                usuarios.ElementAt(idBuscado).setFechaN(pCliente.getgetFechaN());
                usuarios.ElementAt(idBuscado).setTipoCuenta(pCliente.getTipoCuenta());
            }
            else
            {
                throw new Exception("No se pudo modificar al usuario solicitado!");
            }
        }

        //Buscar - B

        public int buscarUsuario(String id)
        {
            int index = -1;

            for (int i = 0; i <= usuarios.Count; i++)
            {
                if (usuarios.ElementAt(i).getID().Equals(id))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        //Eliminar - B

        public void eliminarUsuario(Cliente pCliente)
        {
            int idBuscado = buscarUsuario(pCliente.getID());

            if(idBuscado != 1)
            {
                usuarios.RemoveAt(idBuscado);
            }
            else
            {
                throw new Exception("No se pudo eliminar el usuario solicitado");
            }
        }

        //Cambiar Estado - B

        public void cambiarEstado(Cliente pCliente)
        {
            int idBuscado = buscarUsuario(pCliente.getID());

            if (usuarios.ElementAt(idBuscado).getID() == pCliente.getID())
            {
                if(pCliente.getTipoCuenta() == Cliente.Cuentas.STANDAR )
                {
                    pCliente.setTipoCuenta(Cliente.Cuentas.VIP);
                }
                else if(pCliente.getTipoCuenta() == Cliente.Cuentas.VIP)
                {
                    pCliente.setTipoCuenta(Cliente.Cuentas.STANDAR);
                }
                else
                {
                    throw new Exception("El Cliente no tiene un tipo de cuenta definido");
                }
            }
            else
            {
                throw new Exception("No se encontro el Usuario");
            }
        }

        //Contar Usuarios - B

        public int contarUsuarios()
        {
            int cantidad = usuarios.Count;
            return cantidad;
        }

    }
}

    

