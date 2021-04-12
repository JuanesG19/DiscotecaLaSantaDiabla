using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{

    class Cliente
    {
        //ENUMS

        //Enum para el Tipo de Cliente
        public enum Cuenta
        {
            VIP, STANDAR
        }

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
        private Cuenta tipoCuenta;


        //Constructor

        public Cliente(String id, String nombre, String apellido, String telefono, Cuenta pTipoCuenta, String fechaN)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaN = fechaN;
            this.telefono = telefono;
            this.tipoCuenta = pTipoCuenta;
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

        public string getApellido() => apellido;

        public void setApellido(String pApellido)
        {
            apellido = pApellido;
        }

        public string getgetFechaN() => fechaN;

        public void setFechaN(String pFechaN)
        {
            fechaN = pFechaN;
        }

        public String getTelefono() => telefono;

        public void setTelefono(String pTelefono)
        {
            telefono = pTelefono;
        }

        public Cuenta getTipoCuenta() => tipoCuenta;

        public void setTipoCuenta(Cuenta pTipoCuenta)
        {
            tipoCuenta = pTipoCuenta;
        }



    }
}
