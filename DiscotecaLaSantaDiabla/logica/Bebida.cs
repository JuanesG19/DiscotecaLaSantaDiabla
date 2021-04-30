using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Bebida
    {
        //ESTE ES EL ULTIMO

        //ATRIBUTOS
        private  static List<Producto> bebidas = null;  
         

        //CONSTRUCTOR
        public Bebida()
        {
            bebidas = new List<Producto>();

            bebidas.Add(new Producto(1000, "Aguila", 5000, "350 ml", 10));
            bebidas.Add(new Producto(1001, "Poker", 5000, "350 ml", 10));
            bebidas.Add(new Producto(1002, "Corona", 8000, "350 ml", 10));
            bebidas.Add(new Producto(1003, "Costeña", 3800, "350 ml", 10));
            bebidas.Add(new Producto(1004, "Tapa Roja", 50000, "750 ml", 5));



            bebidas.Add(new Producto(2000, "Buchanan's", 250000, "750 ml", 10));
            bebidas.Add(new Producto(2001, "Jagermeister", 150000, "700 ml", 10));
            bebidas.Add(new Producto(2002, "Smirnoff", 120000, "700 ml", 10));         
            
        }

        //METODOS GET
        public static List<Producto> darBebidas() => bebidas;        

        //METODOS.....

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
      
        //CONTAR - B
        public static int contarBebidas()
        {
            int cantBebidas = bebidas.Count;
            return cantBebidas;
        }
    

        //ELIMINAR - B

        public static void eliminarBebida(int id)
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

        //MODIFICAR - B
        public static void modificarBebida(Producto pProducto, int id)
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


        //BUSCAR - B

        public static Producto buscarBebida(int id)
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
    }
}
