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
        private int id;

        //Nombre del Cliente
        private String nombre;

        //Apellido del Cliente
        private String apellido;

        //Fecha de Nacimiento del Cliente
        private String fechaN;

        //Telefono del Cliente
        private int telefono;

        //Fecha de Creacion De Cuenta del Cliente
        private String fechaCreacionC;

        //Tipo de cuenta del Cliente
        private Cuenta tipoCuenta;


        //Constructor

        public Cliente(int id, string nombre, string apellido, string fechaN, int telefono, string fechaCreacionC, Cuenta pTipoCuenta)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaN = fechaN;
            this.telefono = telefono;
            this.fechaCreacionC = fechaCreacionC;
            this.tipoCuenta = pTipoCuenta;
        }

        //Metodos get y set de los atributos del cliente
        public int getID() => id;

        public void setID(int pID)
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

        public int getTelefono() => telefono;

        public void setTelefono(int pTelefono)
        {
            telefono = pTelefono;
        }

        public string getFechaCreacionC() => fechaCreacionC;

        public void setFechaCreacionC(String pFechaCreacionC)
        {
            fechaCreacionC = pFechaCreacionC;
        }

        public Cuenta getTipoCuenta() => tipoCuenta;

        public void setTipoCuenta(Cuenta pTipoCuenta)
        {
            tipoCuenta = pTipoCuenta;
        }



    }
}
