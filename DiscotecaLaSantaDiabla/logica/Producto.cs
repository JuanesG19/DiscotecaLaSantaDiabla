﻿using System;
using System.Collections.Generic;
using System.Text;

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
              
        //CONSTRUCTOR
        public Producto(int pIdBebida, String pNombre, double pPrecio, String pPresentacion, int pCantidad)
        {
            idBebida = pIdBebida;
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
