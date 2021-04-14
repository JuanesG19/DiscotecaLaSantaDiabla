using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Bebidas
    {
        //ATRIBUTOS
        private static List<Producto> bebidas = new List<Producto>();
        private static List<Producto> bebidasEspeciales = new List<Producto>();

        //CONSTRUCTOR

        //METODOS GET
        public static List<Producto> darBebidas() => bebidas;

        public static List<Producto> darBebidasEspeciales() => bebidasEspeciales;

        //METODOS...

        //AGREGAR - B

        public static void agregarBebida(Producto pProducto)
        {
            Producto aAgregar = buscarBebida(pProducto.getIdBebida());

            if (aAgregar == null)
            {
                bebidas.Add(pProducto);
            }
            else
            {
                throw new Exception("La bebida ya se encuentra agregado !");
            }

        }

        public static void agregarBebidaEspecial(Producto pProducto)
        {
            Producto aAgregar = buscarBebidaEspecial(pProducto.getIdBebida());

            if (aAgregar == null)
            {
                bebidasEspeciales.Add(pProducto);
            }
            else
            {
                throw new Exception("La bebida ya se encuentra agregado !");
            }

        }

        //CONTAR - B

        public static int contarBebidas()
        {
            int cantBebidas = bebidas.Count;
            return cantBebidas;
        }

        public static int contarBebidasEspeciales()
        {
            int cantBebidasEsp = bebidasEspeciales.Count;
            return cantBebidasEsp;
        }

        //ELIMINAR - B

        public void eliminarBebida(String id, Producto pProducto)
        {
            Producto aModificar = buscarBebida(id);

            if (aModificar != null)
            {
                int pos = bebidas.IndexOf(aModificar);
                bebidas.RemoveAt(pos);

            }
            else
            {
                throw new Exception("No se pudo eliminar la bebida solicitado !");
            }
        }

        public static void eliminarBebidaEspecial(String id)
        {
            Producto aModificar = buscarBebidaEspecial(id);

            if (aModificar != null)
            {
                int pos = bebidasEspeciales.IndexOf(aModificar);
                bebidasEspeciales.RemoveAt(pos);

            }
            else
            {
                throw new Exception("No se pudo eliminar la bebida solicitado !");
            }
        }

        //MODIFICAR - B

        public static void modificarBebida(Producto pProducto, String id)
        {
            Producto aModificar = buscarBebida(id);

            if (aModificar != null)
            {
                int pos = bebidas.IndexOf(aModificar);

                bebidas.RemoveAt(pos);
                bebidas.Insert(pos, pProducto);
            }
            else
            {
                throw new Exception("No se pudo modificar la bebida solicitada !");
            }
        }

        public static void modificarBebidaEspecial(Producto pProducto, String id)
        {
            Producto aModificar = buscarBebidaEspecial(id);

            if (aModificar != null)
            {
                int pos = bebidasEspeciales.IndexOf(aModificar);

                bebidas.RemoveAt(pos);
                bebidas.Insert(pos, pProducto);
            }
            else
            {
                throw new Exception("No se pudo modificar la bebida solicitada !");
            }
        }

        //BUSCAR - B

        public static Producto buscarBebida(String id)
        {
            Producto buscado = null;

            foreach (Producto p in bebidas)
            {
                if (p.getIdBebida().Equals(id))

                {
                    buscado = p;
                    break;
                }
            }
            return buscado;
        }

        public static Producto buscarBebidaEspecial(String id)
        {
            Producto buscado = null;

            foreach (Producto p in bebidasEspeciales)
            {
                if (p.getIdBebida().Equals(id))

                {
                    buscado = p;
                    break;
                }
            }
            return buscado;
        }

    }


}
