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

        private const int CAPACIDAD_ESPECIAL = 60;
        private const int CAPACIDAD_A = 30;
        private const int CAPACIDAD_B = 30;
        private const int CAPACIDAD_C = 30;
        private const int CAPACIDAD_D = 30;
        private const int CAPACIDAD_PALCO = 60;

        private static int reservasEspecial;
        private static int reservasA;
        private static int reservasB;
        private static int reservasC;
        private static int reservasD;
        private static int reservasVIP;

        public TipoZona zona;

        private static int ingreso;

        public static int getIngreso() => ingreso;

        public static void setIngreso(int pIngreso)
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
            if ((reservasEspecial += ingreso) == AccederZona.CAPACIDAD_ESPECIAL)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else if((reservasEspecial += ingreso) > AccederZona.CAPACIDAD_ESPECIAL)
            {
                int exceso = reservasEspecial - AccederZona.CAPACIDAD_ESPECIAL;
                throw new Exception("Se excedio el cupo de la zona especial por: "+ exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasEspecial += ingreso;
            }
        }
        
        public static void reservarZonaA()
        {
            if (reservasA == AccederZona.CAPACIDAD_A)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else if ((reservasA += ingreso )> AccederZona.CAPACIDAD_A)
            {
                int exceso = reservasA - AccederZona.CAPACIDAD_A;
                reservasA -= ingreso;
                throw new Exception("Se excedio el cupo de la zona a por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasA += ingreso;
            }


        }

        public static void reservarZonaB()
        {
            if ((reservasB += ingreso) == AccederZona.CAPACIDAD_B)
            {
                throw new Exception("La zona B ya se encuentra al maximo de su capacidad");
            }
            else if ((reservasB += ingreso) > AccederZona.CAPACIDAD_B)
            {
                int exceso = reservasB- AccederZona.CAPACIDAD_B;
                throw new Exception("Se excedio el cupo de la zona B por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasB += ingreso;
            }

        }

        public static void reservarZonaC()
        {
            if ((reservasC += ingreso) == AccederZona.CAPACIDAD_C)
            {
                throw new Exception("La zona C ya se encuentra al maximo de su capacidad");
            }
            else if ((reservasC += ingreso) > AccederZona.CAPACIDAD_C)
            {
                int exceso = reservasC - AccederZona.CAPACIDAD_C;
                throw new Exception("Se excedio el cupo de la zona especial por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasC += ingreso;
            }

        }

        public static void reservarZonaD()
        {
            if ((reservasD += ingreso) == AccederZona.CAPACIDAD_D)
            {
                throw new Exception("La zona D ya se encuentra al maximo de su capacidad");
            }
            else if ((reservasD += ingreso) > AccederZona.CAPACIDAD_D)
            {
                int exceso = reservasD - AccederZona.CAPACIDAD_D;
                throw new Exception("Se excedio el cupo de la zona D por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasD += ingreso;
            }

        }

        public static void reservarZonaPalco()
        {
            if ((reservasVIP += ingreso) == AccederZona.CAPACIDAD_PALCO)
            {
                throw new Exception("La zona VIP ya se encuentra al maximo de su capacidad");
            }
            else if ((reservasVIP += ingreso) > AccederZona.CAPACIDAD_PALCO)
            {
                int exceso = reservasVIP - AccederZona.CAPACIDAD_PALCO;
                throw new Exception("Se excedio el cupo de la zona VIP por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasVIP+= ingreso;
            }

        }

    }
}
