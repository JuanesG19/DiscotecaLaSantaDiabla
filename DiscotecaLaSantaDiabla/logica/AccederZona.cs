using System;
using System.Collections.Generic;
using System.Drawing;
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
            VIP,
        }

        private const int CAPACIDAD_ESPECIAL = 60;
        private  const int CAPACIDAD_A = 30;
        private const int CAPACIDAD_B = 30;
        private const int CAPACIDAD_C = 30;
        private const int CAPACIDAD_D = 30;
        private const int CAPACIDAD_VIP = 60;

        private static int reservasEspecial;
        private static int reservasA;
        private static int reservasB;
        private static int reservasC;
        private static int reservasD;
        private static int reservasVIP;

       

        public TipoZona zona;

        private static int ingreso;
        private static int salidaZona;

        public AccederZona(TipoZona pZona, int pReservasEspecial, int pReservasA, int pReservasB, int pReservasC, int pReservasD, int pReservasVIP)
        {
            this.zona = pZona;
            reservasEspecial = pReservasEspecial;
            reservasA = pReservasA;
            reservasB = pReservasB;
            reservasC = pReservasC;
            reservasD = pReservasD;
            reservasVIP = pReservasVIP;
        }

        public TipoZona getTipoZona()
        {
            return zona;
        }
        public void setTipoZona(TipoZona pZona)
        {
            zona = pZona;
        }

        public static int getIngreso() => ingreso;

        public static void setIngreso(int pIngreso)
        {
            ingreso = pIngreso;
        }

        public static int getSalidaZona() => salidaZona;

        public static void setSalidaZona(int pEliminarZona)
        {
            salidaZona = pEliminarZona;
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

        public static int darNumReservasVIP()
        {
            return reservasVIP;
        }

        //REALIZAR RESERVAS

        public static void reservarZonaEspecial()
        {
            int temp = reservasEspecial + ingreso;
            if (reservasEspecial == AccederZona.CAPACIDAD_ESPECIAL)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_ESPECIAL)
            {
                //topeZonaEspecial = true;
                int exceso = temp - AccederZona.CAPACIDAD_ESPECIAL;
                throw new Exception("Se excedio el cupo de la zona Especial por: " + exceso + " persona(s)");
            }
            else
            {
                reservasEspecial += ingreso;
            }
        }

        public static void reservarZonaA()
        {
            int temp = reservasA + ingreso;
            if (reservasA == AccederZona.CAPACIDAD_A)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_A)
            {
                int exceso = temp - AccederZona.CAPACIDAD_A;
                throw new Exception("Se excedio el cupo de la zona A por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasA += ingreso;
            }
        }

        public static void reservarZonaB()
        {
            int temp = reservasB + ingreso;

            if (reservasB == AccederZona.CAPACIDAD_B)
            {
                throw new Exception("La Zona B ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_B)
            {
                int exceso = temp - AccederZona.CAPACIDAD_B;
                throw new Exception("Se excedio el cupo de la Zona B por: " + exceso + " persona(s)");
            }
            else
            {
                reservasB += ingreso;
            }

        }

        public static void reservarZonaC()
        {
            int temp = reservasC + ingreso;
            if (reservasC == AccederZona.CAPACIDAD_C)
            {
                throw new Exception("La zona C ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_C)
            {
                int exceso = temp - AccederZona.CAPACIDAD_C;
                throw new Exception("Se excedio el cupo de la zona C por: " + exceso + " persona(s)");
            }
            else
            {
                reservasC += ingreso;
            }

        }

        public static void reservarZonaD()
        {
            int temp = reservasD + ingreso;

            if (reservasD == AccederZona.CAPACIDAD_D)
            {
                throw new Exception("La Zona D ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_D)
            {
                int exceso = temp - AccederZona.CAPACIDAD_D;

                throw new Exception("Se excedio el cupo de la Zona D por: " + exceso + " persona(s)");
            }
            else
            {
                reservasD += ingreso;
            }

        }

        public static void reservarZonaVIP()
        {
            int temp = reservasVIP + ingreso;

            if (reservasVIP == AccederZona.CAPACIDAD_VIP)
            {
                throw new Exception("La zona VIP ya se encuentra al maximo de su capacidad");
            }
            else if (temp > AccederZona.CAPACIDAD_VIP)
            {
                int exceso = temp - AccederZona.reservasVIP;
                throw new Exception("Se excedio el cupo de la zona VIP por: " + exceso + " persona(s)");
            }
            else
            {
                reservasVIP += ingreso;
            }

        }

        public static void salidaZonaEspecial()
        {
            int temp = reservasEspecial;
            int salida = reservasEspecial - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona Especial Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasEspecial
                   + " Personas en la zona");
            }
            else
            {
                reservasEspecial = reservasEspecial - salidaZona;
            }
        }

        public static void salidaZonaA()
        {
            int temp = reservasA;
            int salida = reservasA - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona A Actualmente");
            }
            else if (salida < 0 )
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasA
                                   + " Personas en la zona");
            }
            else
            {
                reservasA = reservasA - salidaZona;
            }
        }

        public static void salidaZonaB()
        {
            int temp = reservasB;
            int salida = reservasB - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona B Actualmente");
            }
            else if (salida < 0 )
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasB
                                  + " Personas en la zona");
            }
            else
            {
                reservasB = reservasB - salidaZona;
               
            }
        }

        public static void salidaZonaC()
        {
            int temp = reservasC;
            int salida = reservasC - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona C Actualmente");
            }
            else if (salida < 0 )
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasC
                                  + " Personas en la zona");
            }
            else
            {
                reservasC = reservasC - salidaZona;
                
            }
        }

        public static void salidaZonaD()
        {
            int temp = reservasD;
            int salida = reservasD - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona D Actualmente");
            }
            else if (salida < 0 )
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasD
                                 + " Personas en la zona");

            }
            else
            {
                reservasD = reservasD - salidaZona;

            }
        }

        public static void salidaZonaVIP()
        {
            int temp = reservasVIP;
            int salida = reservasVIP - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona D Actualmente");
            }
            else if (salida < 0 )
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasVIP
                                  + " Personas en la zona");

            }
            else
            {
                reservasVIP = reservasVIP - salidaZona;

            }
        }

        public static int darCapacidadTotal()
        {
            int capacidad = CAPACIDAD_ESPECIAL + CAPACIDAD_VIP + CAPACIDAD_A + CAPACIDAD_B + CAPACIDAD_C + CAPACIDAD_D;
            return capacidad;

        }

        public static int darNumeroDePersonasIngresasadas()
        {
            int ingresadas = reservasEspecial + reservasA + reservasB + reservasC + reservasD + reservasVIP;

            return ingresadas;
        }

        public static double darAforoTotal()
        {
            int totalCapaciad = darCapacidadTotal();
            int personasIngresadas = darNumeroDePersonasIngresasadas();

            double aforo = (personasIngresadas * 100) / totalCapaciad;
            return aforo;
        }
    }
}

