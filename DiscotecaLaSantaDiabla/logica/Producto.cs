using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Producto
    {

        private String nombre;
        private double precio;
        private String presentacion;
        private int cantidad;

        public Producto(String pNombre, double pPrecio, String pPresentacion, int pCantidad)
        {
            nombre = pNombre;
            precio = pPrecio;
            presentacion = pPresentacion;
            cantidad = pCantidad;
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
