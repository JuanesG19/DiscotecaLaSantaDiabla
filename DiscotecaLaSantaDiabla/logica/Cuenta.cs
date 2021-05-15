using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Cuenta
    {
        public const double MEMBRESIA = 100.000;

        public enum Cuentas
        {
            VIP, STANDAR
        }

        public Boolean haPagadoMembresia()
        {
            return true;
        }
        public Boolean noHaPagadoMembresia()
        {
            return false;
        }

        public Boolean tieneDescuento(Cliente pCliente)
        {
            Boolean descuento = false;

            if (pCliente.getTipoCuenta().Equals(Cuentas.VIP) && haPagadoMembresia())
            {
                descuento = true;
            }

            return descuento;
        }

        public void convertirseEnSocio(Cliente pCliente)
        {
            if (pCliente.getTipoCuenta().Equals(Cuentas.VIP) && haPagadoMembresia())
            {
                throw new Exception("El cliente ya es socio actualmente");
            }
            else
            {
                pCliente.setTipoCuenta(Cuentas.VIP);
            }
        }
    }
}
