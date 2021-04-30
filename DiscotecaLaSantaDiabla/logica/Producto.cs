using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Producto
    {
        private  int idBebida;
        private  String nombre;
        private  double precio;
        private  String presentacion;
        private  int cantidad;
              
        public Producto(int pIdBebida, String pNombre, double pPrecio, String pPresentacion, int pCantidad)
        {
            idBebida = pIdBebida;
            nombre = pNombre;
            precio = pPrecio;
            presentacion = pPresentacion;
            cantidad = pCantidad;           
        }       

        public int getIdBebida() => idBebida;

        public void setidBebida(int pIdBebida)
        {
            idBebida = pIdBebida;
        }


        public String getNombre() => nombre;

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public double getPrecio() => precio;

        public void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        public String getPresentacion() => presentacion;

        public void setPresentacion(String pPresentacion)
        {
            presentacion = pPresentacion;
        }

        public int getCantidad() => cantidad;

        public void setCantidad(int pCantidad)
        {
            cantidad = pCantidad;
        }     
    }
}
