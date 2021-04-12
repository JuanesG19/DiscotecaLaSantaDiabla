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

        public List<Cliente> getUsuarios()
        {
            return usuarios;
        }

        public void crearUsuario(Cliente pCliente)
        {
            usuarios.Add(pCliente);
        }

        public void modificarUsuario(Cliente pCliente)
        {

            int idBuscado = buscarUsuario(pCliente.getID());

            if (usuarios.ElementAt(idBuscado).getID() == pCliente.getID())
            {

                usuarios.ElementAt(idBuscado).setNombre(pCliente.getNombre());
                usuarios.ElementAt(idBuscado).setApellido(pCliente.getApellido());
                usuarios.ElementAt(idBuscado).setTelefono(pCliente.getTelefono());
                usuarios.ElementAt(idBuscado).setNombre(pCliente.getNombre());
                usuarios.ElementAt(idBuscado).setFechaN(pCliente.getgetFechaN());

            }
            else
            {
                throw new Exception("No se pudo modificar al usuario solicitado!");
            }

        }

        public int buscarUsuario(String id)
        {
            int index = 0;

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

        public void eliminarUsuario(Cliente pCliente)
        {

            if (usuarios. > 0)
            {
                foreach (Producto p in bebidas)
                {
                    if (p.getNombre().Equals(pProducto.getNombre()) &&
                        p.getPrecio() == pProducto.getPrecio() &&
                        p.getPresentacion().Equals(pProducto.getPresentacion()) &&
                        cant <= cantidad)
                    {
                        bebidas.Remove(p);
                        cant++;
                    }
                }

            }
            else
            {
                throw new Exception("No hay bebidas " + pProducto.getNombre() + "en el momento");
            }
        }

       

        public void cambiarEstado(Cliente pCliente)
        {

        }

        public int contarUsuarios()
        {
            int cant = 0;

            foreach (Producto p in bebidasEspeciales)
            {
                if (p.getNombre().Equals(pProducto.getNombre()) &&
                   p.getPrecio() == pProducto.getPrecio() &&
                   p.getPresentacion().Equals(pProducto.getPresentacion()))
                {
                    cant++;
                }
            }
            return cant;
        }

    }
}
