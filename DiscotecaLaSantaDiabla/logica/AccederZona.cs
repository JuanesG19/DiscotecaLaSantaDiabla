using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class AccederZona
    {
        public enum TipoZona
        {
            ESPECIAL,
            A,
            B,
            C,
            D,
            PALCO,
        }
              
        public const int CAPACIDAD_ESPECIAL = 60;
        public const int CAPACIDAD_A = 30;
        public const int CAPACIDAD_B = 30;
        public const int CAPACIDAD_C = 30;
        public const int CAPACIDAD_D = 30;
        public const int CAPACIDAD_PALCO = 60;

        public static int reservasEspecial;
        public static int reservasA;
        public static int reservasB;
        public static int reservasC;
        public static int reservasD;
        public static int reservasVIP;

        public TipoZona zona;

        private static int ingreso;

        public static int getIngreso() => ingreso;

        public static void setIngresar(int pIngreso)
        {
            ingreso = pIngreso;
        }



        public AccederZona(TipoZona pZona, int pReservasEspecial, int pReservasA, int pReservasB, int pReservasC, int pReservasD, int pReservasPalco)
        {
            this.zona = pZona;
            reservasEspecial = pReservasEspecial;
            reservasA = pReservasA;
            reservasB = pReservasB;
            reservasC = pReservasC;
            reservasD = pReservasD;
            reservasVIP = pReservasPalco;
        }

        public TipoZona GetTipoZona()
        {
            return zona;
        }
        public void setTipoZona(TipoZona pZona)
        {
            zona = pZona;
        }

        public static int darNumReservasEspecial()
        {
            return reservasEspecial;
        }

        public static int darNumReservasA()
        {
            return reservasA;
        }

        public static int darNumReservasB()
        {
            return reservasB;
        }

        public static int darNumReservasC()
        {
            return reservasC;
        }

        public static int darNumReservasD()
        {
            return reservasD;
        }

        public static int darNumReservasPalco()
        {
            return reservasVIP;
        }

        //REALIZAR RESERVAS

        public static void reservarZonaEspecial()
        {
            if (reservasEspecial == AccederZona.CAPACIDAD_ESPECIAL)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else if(reservasEspecial > AccederZona.CAPACIDAD_ESPECIAL)
            {
                int exceso = reservasEspecial - AccederZona.CAPACIDAD_ESPECIAL;
                throw new Exception("Se excedio el cupo de la zona especial por: "+ exceso + " persona(s)");
                reservasEspecial -= exceso;
            }
        }
        /**
        public static void reservarZonaA()
        {
            if (reservasA == AccederZona.CAPACIDAD_A)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");

            }
            else if (reservasA > AccederZona.CAPACIDAD_A)
            {
                int exceso = reservasA - AccederZona.CAPACIDAD_ESPECIAL;
                throw new Exception("Se excedio el cupo de la zona A por: " + exceso + " persona(s)");
                reservasA -= exceso;
            }
            
        }

        public static void reservarZonaB()
        {
            if (reservasB  <= AccederZona.CAPACIDAD_B)
            {
                reservasB = reservasB + numeroPersonas;

            }
            else if (reservasB == AccederZona.CAPACIDAD_B)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasB + numeroPersonas - AccederZona.CAPACIDAD_B;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona B");

            }
        }

        public static void reservarZonaC()
        {
            if (reservasC + numeroPersonas <= AccederZona.CAPACIDAD_C)
            {
                reservasC = reservasC + numeroPersonas;

            }
            else if (reservasC == AccederZona.CAPACIDAD_C)
            {
                throw new Exception("La zona C ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasC + numeroPersonas - AccederZona.CAPACIDAD_C;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona C");

            }
        }

        public static void reservarZonaD()
        {
            if (reservasD + numeroPersonas <= AccederZona.CAPACIDAD_D)
            {
                reservasD = reservasD + numeroPersonas;

            }
            else if (reservasD == AccederZona.CAPACIDAD_D)
            {
                throw new Exception("La zona D ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasD + numeroPersonas - AccederZona.CAPACIDAD_D;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona D");

            }
        }

        public static void reservarZonaPalco()
        {
            if (reservasVIP + numeroPersonas <= AccederZona.CAPACIDAD_PALCO)
            {
                reservasVIP = reservasVIP + numeroPersonas;

            }
            else if (reservasVIP == AccederZona.CAPACIDAD_PALCO)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasVIP + numeroPersonas - AccederZona.CAPACIDAD_PALCO;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona B");

            }
        }
    */

    }
}
