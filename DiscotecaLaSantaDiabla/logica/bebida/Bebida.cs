using System;
using System.Collections.Generic;
using System.Text;
using static DiscotecaLaSantaDiabla.logica.Membresia;

namespace DiscotecaLaSantaDiabla.logica
{
    class Bebida
    {
        
        //ATRIBUTOS

        //Lista de bebidas
        private static List<Producto> bebidas = new List<Producto>();

        //Numero de bebidas
        private static int numBebidas;

        //METODOS 

        // Metodo Get bebidas
        public static List<Producto> getBebidas() => bebidas;

        //Metodo Get numero de bebidas
        public int getNumBebidas() => numBebidas;
       

        //Metodo Set numero de bebidas
        public static void setNumBebidas(int pNumBebidas)
        {
            numBebidas = pNumBebidas;
        }

        //Metodo agregar Bebida
        public static void agregarBebida(Producto pProducto)
        {
            Producto aAgregar = buscarBebida(pProducto.getIdBebida());

            if (aAgregar == null)
            {
                bebidas.Add(pProducto);
            }
            else
            {
                throw new Exception("La bebida ya se encuentra agregada!");
            }
        }

        //Metodo contar bebida
        public static int contarBebidas()
        {
            int cantBebidas = bebidas.Count;
            return cantBebidas;
        }


        //Metodo eliminar bebida
        public static void eliminarBebida(String id)
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

        //Metodo modificar bebida
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


        //Metodo buscar bebida
        public static Producto buscarBebida(String id)
        {
            Producto buscado = null;

            foreach (Producto p in bebidas)
            {
                if (p.getIdBebida() == id)

                {
                    buscado = p;
                    break;
                }
            }
            return buscado;
        }

        // Metodo Pedir Bebida 
        public static void pedirBebida(String id)
        {
            Producto p = Bebida.buscarBebida(id);

            String idNuevo = p.getIdBebida();
            String nombreN = p.getNombre();
            double precioN = p.getPrecio();
            String presentacionN = p.getPresentacion();
            Membresia.Membresias tipoBebida = p.getTipoBebida();


            if (p.getIdBebida() == id)
            {
                if (p.getCantidad() == 0)
                {
                    throw new Exception("No hay bebidas disponibles");
                }
                else if (numBebidas > p.getCantidad())
                {
                    throw new Exception("En el momento solo hay " + p.getCantidad() + "cantidades de "+ p.getNombre()+ "disponibles");
                }
                else
                {
                    int pos = bebidas.IndexOf(p);
                    bebidas.RemoveAt(pos);
                    int nuevaCant = p.getCantidad() - numBebidas;

                    Producto nuevo = new Producto(idNuevo, nombreN, precioN, presentacionN, nuevaCant, tipoBebida);
                    bebidas.Insert(pos, nuevo);
                }
            }
        }

        
  
        public static double descuentoBebidaVIP(double totalPrecio)
        {
            double descuento = totalPrecio-((totalPrecio * 10) / 100);
            return descuento;
        }
        

        public static void limpiarListaBebida()
        {
            for (int i = 0; i < bebidas.Count; i++)
            {
                bebidas.RemoveAt(i);
                i--;
            }
        }
    }
}
