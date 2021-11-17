using System;
using static DiscotecaLaSantaDiabla.logica.Zona;

namespace DiscotecaLaSantaDiabla.logica
{
    public class Reservas
    {
        //ATRIBUTOS

        public String tipoZona;

        private static int reservasEspecial;
        private static int reservasA;
        private static int reservasB;
        private static int reservasC;
        private static int reservasD;
        private static int reservasVIP;

        private static int ingreso;
        private static int salidaZona;

        //CONSTRUCTOR
        public Reservas(String pZona, int pReservasEspecial, int pReservasA, int pReservasB, int pReservasC, int pReservasD, int pReservasVIP)
        {
            tipoZona = pZona;
            reservasEspecial = pReservasEspecial;
            reservasA = pReservasA;
            reservasB = pReservasB;
            reservasC = pReservasC;
            reservasD = pReservasD;
            reservasVIP = pReservasVIP;
        }

        //METODOS

        //Metodo Get tipoZona
        public String getTipoZona() => tipoZona;
      
        //Metodo Set tipoZona
        public void setTipoZona(String pZona)
        {
            tipoZona = pZona;
        }

        //Metodo Get Ingreso a zona
        public static int getIngreso() => ingreso;

        //Metodo Set Ingreso a zona
        public static void setIngreso(int pIngreso)
        {
            ingreso = pIngreso;
        }

        //Metodo Get Salida a zona
        public static int getSalidaZona() => salidaZona;

        //Metodo Set Salida a zona
        public static void setSalidaZona(int pEliminarZona)
        {
            salidaZona = pEliminarZona;
        }

        //Metodo Get Numreo de reservas especiales
        public static int getNumReservasEspecial() => reservasEspecial;

        //Metodo Get Numreo de reservas zona A
        public static int getNumReservasA() => reservasA;

        //Metodo Get Numreo de reservas zona B
        public static int getNumReservasB() => reservasB;
     
        //Metodo Get Numreo de reservas zona C
        public static int getNumReservasC() => reservasC;
       
        //Metodo Get Numreo de reservas zona D
        public static int getNumReservasD() => reservasD;
      
        //Metodo Get Numreo de reservas zona VIP
        public static int getNumReservasVIP() => reservasVIP;

    }
}


