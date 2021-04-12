using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Bebidas
    {

        //ATRIBUTOS
        private List<Producto> bebidas;
        private List<Producto> bebidasEspeciales;

        //CONSTRUCTOR
        Bebidas()
        {
            bebidas = new List<Producto>();
            bebidasEspeciales = new List<Producto>();
        }

        //METODOS GET
        public List<Producto> darBebidas() => bebidas;

        public List<Producto> darBebidasEspeciales() => bebidasEspeciales;

        //METODOS...

       //AGREGAR - B

        public void agregarBebida(Producto pProducto)
        {
            int agregado = darPosicionBebida(pProducto);

            if (agregado == -1)
            {
                bebidas.Add(pProducto);
            }
            else
            {
                throw new Exception("El produto ya se encuentra agregado !");
            }

        }

        public void agregarBebidaEspecial(Producto pProducto)
        {
            int agregado = darPosicionBebidaEspecial(pProducto);

            if (agregado == -1)
            {
                bebidasEspeciales.Add(pProducto);
            }
            else
            {
                throw new Exception("El produto ya se encuentra agregado !");
            }

        }

        //CONTAR - B

        public int contarBebidas()
        {
            int cantBebidas = bebidas.Count;
            return cantBebidas;
        }

        public int contarBebidasEspeciales()
        {
            int cantBebidasEsp = bebidasEspeciales.Count;
            return cantBebidasEsp;
        }

        //ELIMINAR - B

        public void eliminarBebida(Producto pProducto)
        {
            int aEliminar = darPosicionBebida(pProducto);

            if (aEliminar != 1)
            {
                bebidas.RemoveAt(aEliminar);
                
            }
            else
            {
                throw new Exception("No se pudo eliminar el producto solicitado !");
            }
        }

        public void eliminarBebidaEspecial(Producto pProducto)
        {
            int aEliminar = darPosicionBebidaEspecial(pProducto);

            if (aEliminar != 1)
            {
                bebidasEspeciales.RemoveAt(aEliminar);

            }
            else
            {
                throw new Exception("No se pudo eliminar el producto solicitado !");
            }
        }

        //MODIFICAR - B

        public void modificarBebida(Producto pProducto)
        {
            if (contarBebidasEspeciales() > 0)
            {
                foreach (Producto p in bebidas)
                {
                    if (p.getNombre().Equals(pProducto.getNombre()) &&
                        p.getPrecio() == pProducto.getPrecio() &&
                        p.getPresentacion().Equals(pProducto.getPresentacion()))
                    {
                        p.setNombre(pProducto.getNombre());
                        p.setPrecio(pProducto.getPrecio());
                        p.setPresentacion(pProducto.getPresentacion());
                    }
                }
            }
            else
            {
                throw new Exception("No se pudo modificar la bebida " + pProducto.getNombre());
            }
        }

        public void modificarBebidaEspecial(Producto pProducto)
        {
            if (contarBebidasEspeciales() > 0)
            {
                foreach (Producto p in bebidasEspeciales)
                {
                    if (p.getNombre().Equals(pProducto.getNombre()) &&
                        p.getPrecio() == pProducto.getPrecio() &&
                        p.getPresentacion().Equals(pProducto.getPresentacion()))
                    {
                        p.setNombre(pProducto.getNombre());
                        p.setPrecio(pProducto.getPrecio());
                        p.setPresentacion(pProducto.getPresentacion());
                    }
                }
            }
            else
            {
                throw new Exception("No se pudo modificar la bebida " + pProducto.getNombre());
            }
        }

        //BUSCAR - B

        public Producto buscarBebida(String nombre, int precio)
        {
            Producto buscado = null;

            foreach (Producto p in bebidas)
            {
                if (p.getNombre().Equals(nombre) && p.getPrecio() == precio)

                {
                    buscado = new Producto(p.getNombre(), p.getPrecio(), p.getPresentacion(), p.getCantidad());
                }
            }
            return buscado;
        }

        public Producto buscarBebidaEspecial(String nombre, int precio)
        {
            Producto buscado = null;

            foreach (Producto p in bebidasEspeciales)
            {
                if (p.getNombre().Equals(nombre) && p.getPrecio() == precio)
   
                {
                    buscado = new Producto(p.getNombre(), p.getPrecio(), p.getPresentacion(), p.getCantidad());
                }
            }
            return buscado;
        }

        //DAR POSICION - B
        public int darPosicionBebida(Producto pProducto)

        {
            int pos = -1;
            int index = 0;
            foreach (Producto p in bebidas)
            {
                if (pProducto.getNombre().Equals(p.getNombre()) &&
                    pProducto.getPrecio() == p.getPrecio() &&
                    pProducto.getPresentacion().Equals(p.getPresentacion())
                    && pProducto.getCantidad() == p.getCantidad())
                {
                    pos = index;
                    break;

                }
                else
                {
                    index++;
                }

            }

            return pos;
        }

        public int darPosicionBebidaEspecial(Producto pProducto)
        {
            int pos = -1;
            int index = 0;
            foreach (Producto p in bebidasEspeciales)
            {
                if (pProducto.getNombre().Equals(p.getNombre()) &&
                    pProducto.getPrecio() == p.getPrecio() &&
                    pProducto.getPresentacion().Equals(p.getPresentacion())
                    && pProducto.getCantidad() == p.getCantidad())
                {
                    pos = index;
                    break;
                }
                else
                {
                    index++;
                }
            }
            return pos;
        }

    }
}
