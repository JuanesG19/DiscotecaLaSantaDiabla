using System;
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

        //Fecha de membresia del Cliente
        private String fechaVencimientoM;

        //CONSTRUCTOR
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
                this.fechaVencimientoM = null;
            }
            catch
            {
                throw new Exception("fatal Fatal Error");
            }
            
        }

        //METODOS

        //Metodo Get Id del cliente
        public String getID() => id;

        //Metodo Set Id del cliente
        public void setID(String pID)
        {
            id = pID;
        }

        //Metodo Get Nombre del cliente
        public String getNombre() => nombre;

        //Metodo Set Nombre del cliente
        public void setNombre(String pNombre)
        {
            nombre = pNombre;
        }

        //Metodo Get Apellido del cliente
        public String getApellido() => apellido;

        //Metodo Set Apellido del cliente
        public void setApellido(String pApellido)
        {
            apellido = pApellido;
        }

        //Metodo Get fechaNacimiento del cliente
        public String getFechaN() => fechaN;

        //Metodo Set fechaNacimiento del cliente
        public void setFechaN(String pFechaN)
        {
            fechaN = pFechaN;
        }
        
        //Metodo Get telefono del cliente
        public String getTelefono() => telefono;

        //Metodo Set telefono del cliente
        public void setTelefono(String pTelefono)
        {
            telefono = pTelefono;
        }

        //Metodo Get TipoCuenta del cliente
        public Cuentas getTipoCuenta() => tipoCuenta;

        //Metodo Set TipoCuenta del cliente
        public void setTipoCuenta(Cuentas pTipoCuenta)
        {
            tipoCuenta = pTipoCuenta;
        }

        //Metodo Get Id del cliente
        public String getFechaVencimientoM() => fechaVencimientoM;

        //Metodo Set fecha Membresia cliente
        public void setFechaVencimientoM(String pFechaVencimientoM)
        {
            fechaVencimientoM = pFechaVencimientoM;
        }
    }
}
