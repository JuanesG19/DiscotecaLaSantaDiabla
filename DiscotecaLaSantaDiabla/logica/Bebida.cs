using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Bebida
    {
        //ESTE ES EL ULTIMO

        //ATRIBUTOS
        private  List<Producto> bebidas = null;
        private  List<Producto> bebidasEspeciales = null;



        //CONSTRUCTOR
        public Bebida()
        {
            bebidas = new List<Producto>();

            bebidas.Add(new Producto(1000, "Aguila", 5000, "350 ml", 10));
            bebidas.Add(new Producto(1001, "Poker", 5000, "350 ml", 10));
            bebidas.Add(new Producto(1002, "Corona", 8000, "350 ml", 10));
            bebidas.Add(new Producto(1003, "Costeña", 3800, "350 ml", 10));
            bebidas.Add(new Producto(1004, "Tapa Roja", 50000, "750 ml", 5));
           
            bebidasEspeciales = new List<Producto>();
                      
            bebidasEspeciales.Add(new Producto(2000, "Buchanan's", 250000, "750 ml", 10));
            bebidasEspeciales.Add(new Producto(2001, "Jagermeister", 150000, "700 ml", 10));
            bebidasEspeciales.Add(new Producto(2002, "Smirnoff", 120000, "700 ml", 10));         
            
        }

        //METODOS GET
        public List<Producto> darBebidas() => bebidas;

        public List<Producto> darBebidasEspeciales() => bebidasEspeciales;

        //METODOS.....

        //AGREGAR - B

        public  void agregarBebida(Producto pProducto)
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

        public  void agregarBebidaEspecial(Producto pProducto)
        {
            Producto aAgregar = buscarBebidaEspecial(pProducto.getIdBebida());

            if (aAgregar == null)
            {
                bebidasEspeciales.Add(pProducto);
            }
            else
            {
                throw new Exception("La bebida especial ya se encuentra agregado !");
            }
        }

        //CONTAR - B
        public  int contarBebidas()
        {
            int cantBebidas = bebidas.Count;
            return cantBebidas;
        }

        public  int contarBebidasEspeciales()
        {
            int cantBebidasEsp = bebidasEspeciales.Count;
            return cantBebidasEsp;
        }

        //ELIMINAR - B

        public void eliminarBebida(int id, Producto pProducto)
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

        public void eliminarBebidaEspecial(int id)
        {
            Producto aModificar = buscarBebidaEspecial(id);

            if (aModificar != null)
            {
                int pos = bebidasEspeciales.IndexOf(aModificar);
                bebidasEspeciales.RemoveAt(pos);
            }
            else
            {
                throw new Exception("No se pudo eliminar la bebida especial solicitado !");
            }
        }

        //MODIFICAR - B
        public void modificarBebida(Producto pProducto, int id)
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

        public  void modificarBebidaEspecial(Producto pProducto, int id)
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
                throw new Exception("No se pudo modificar la bebida especial solicitada !");
            }
        }

        //BUSCAR - B

        public  Producto buscarBebida(int id)
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

        public  Producto buscarBebidaEspecial(int id)
        {
            Producto buscado = null;

            foreach (Producto p in bebidasEspeciales)
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
