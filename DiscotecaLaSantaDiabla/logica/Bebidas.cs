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


        //METODOS

        public void agregarBebida(Producto pProducto, int cantidad)
        {
            for (int i = 0; i <= cantidad; i++)
            {
                bebidas.Add(pProducto);
            }
        }

        public void agregarBebidaEspecial(Producto pProducto, int cantidad)
        {
            for (int i = 0; i <= cantidad; i++)
            {
                bebidasEspeciales.Add(pProducto);
            }

        }

        //CONTAR

        public int contarBebida(Producto pProducto)
        {
            int cant = 0;
            foreach (Producto p in bebidas)
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


        public int contarBebidasEspeciales(Producto pProducto)
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
        //ELIMINAR

        public void eliminarBebida(Producto pProducto, int cantidad)
        {
            int cant = 0;

            if (contarBebida(pProducto) > 0)
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

        public void eliminarBebidaEspecial(Producto pProducto, int cantidad)
        {
            int cant = 0;

            if (contarBebidasEspeciales(pProducto) > 0)
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

        //MODIFICAR

        public void modificarBebida(Producto pProducto)
        {
            if (contarBebidasEspeciales(pProducto) > 0)
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
            if (contarBebidasEspeciales(pProducto) > 0)
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

        //BUSCAR

        public String buscarBebida(Producto pProducto)
        {
            int cantidad = contarBebida(pProducto);

            return "Hay " + cantidad + " " + pProducto.getNombre() + " de: " + pProducto.getPresentacion() + " a: " + pProducto.getPrecio();

        }

        public String buscarBebidaEspecial(Producto pProducto)
        {
            int cantidad = contarBebidasEspeciales(pProducto);

            return "Hay " + cantidad + " " + pProducto.getNombre() + " de: " + pProducto.getPresentacion() + " a: " + pProducto.getPrecio();
        }
    }
}
