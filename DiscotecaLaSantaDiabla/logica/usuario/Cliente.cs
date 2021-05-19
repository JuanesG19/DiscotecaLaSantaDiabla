﻿using System;
using System.Collections.Generic;
using System.Text;
using static DiscotecaLaSantaDiabla.logica.Cuenta;

namespace DiscotecaLaSantaDiabla.logica
{

    class Cliente
    {
        
        //ATRIBUTOS

        //Id del Cliente
        private String id;

        //Nombre del Cliente
        private String nombre;

        //Apellido del Cliente
        private String apellido;

        //Fecha de Nacimiento del Cliente
        private String fechaN;

        //Telefono del Cliente
        private String telefono;

        //Tipo de cuenta del Cliente
        private Cuentas tipoCuenta;

        //Constructor
        public Cliente(String id, String nombre, String apellido, String telefono, Cuentas pTipoCuenta, String fechaNacimiento)
        {
            try
            {
                this.id = id;
                this.nombre = nombre;
                this.apellido = apellido;
                this.fechaN = fechaNacimiento;
                this.telefono = telefono;
                this.tipoCuenta = pTipoCuenta;
            }
            catch
            {
                throw new Exception("Error");
            }
            
        }

        //Metodos get y set de los atributos del cliente
        public String getID() => id;

        public void setID(String pID)
        {
            id = pID;
        }

        public String getNombre() => nombre;

        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        public String getApellido() => apellido;

        public void setApellido(String pApellido)
        {
            apellido = pApellido;
        }

        public String getFechaN() => fechaN;

        public void setFechaN(String pFechaN)
        {
            fechaN = pFechaN;
        }

        public String getTelefono() => telefono;

        public void setTelefono(String pTelefono)
        {
            telefono = pTelefono;
        }
        public Cuentas getTipoCuenta() => tipoCuenta;

        public void setTipoCuenta(Cuentas pTipoCuenta)
        {
            tipoCuenta = pTipoCuenta;
        }
    }
}
