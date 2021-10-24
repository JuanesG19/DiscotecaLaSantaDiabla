using System;
using System.Collections.Generic;
using System.Text;
using static DiscotecaLaSantaDiabla.logica.Membresia;

namespace DiscotecaLaSantaDiabla.logica
{
    class Producto
    {

        //ATRIBTOS

        //Id de la bebida
        private  int idBebida;

        //Nombre de la bebida
        private  String nombre;

        //Precio Bebida
        private  double precio;

        //Presentacion Bebida
        private  String presentacion;

        //Cantidad de Bebidas
        private  int cantidad;

        //Tipo Bebida
        private Membresia.Membresias cuenta;
              
        //CONSTRUCTOR
        public Producto(int pIdBebida, String pNombre, double pPrecio, String pPresentacion, int pCantidad, Membresia.Membresias pTipoCuenta)
        {
            idBebida = pIdBebida;
            cuenta = pTipoCuenta;
            nombre = pNombre;
            precio = pPrecio;
            presentacion = pPresentacion;
            cantidad = pCantidad;   
            
        }       

        //METODOS

        //Metodo Get Id Bebida
        public int getIdBebida() => idBebida;

        //Metodo Set Id Bebida
        public void setidBebida(int pIdBebida)
        {
            idBebida = pIdBebida;
        }

        //Metodo Get Tipo Bebida
        public Membresia.Membresias getTipoBebida() => cuenta;

         //Metodo Set Tipo Bebida
        public void setTipoBebida(Membresia.Membresias pTipoCuenta)
        {
            cuenta = pTipoCuenta;
        }

        //Metodo Get Nombre
        public String getNombre() => nombre;

        //Metodo Set Nombre
        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        //Metodo Get Precio
        public double getPrecio() => precio;

        //Metodo Get Precio
        public void setPrecio(double pPrecio)
        {
            precio = pPrecio;
        }

        //Metodo Get Presentacion
        public String getPresentacion() => presentacion;

        //Metodo Set Presentacion
        public void setPresentacion(String pPresentacion)
        {
            presentacion = pPresentacion;
        }

        //Metodo Get Cantidad
        public int getCantidad() => cantidad;

        //Metodo Set Cantidad
        public void setCantidad(int pCantidad)
        {
            cantidad = pCantidad;
        }     
    }
}
