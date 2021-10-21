using System;
using static DiscotecaLaSantaDiabla.logica.Zona;

namespace DiscotecaLaSantaDiabla.logica
{
    public class Reservas
    {

        //ATRIBUTOS

        public TipoZona tipoZona;

        private static int reservasEspecial;
        private static int reservasA;
        private static int reservasB;
        private static int reservasC;
        private static int reservasD;
        private static int reservasVIP;

        private static int ingreso;
        private static int salidaZona;

        //CONSTRUCTOR
        public Reservas(TipoZona pZona, int pReservasEspecial, int pReservasA, int pReservasB, int pReservasC, int pReservasD, int pReservasVIP)
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
        public TipoZona getTipoZona() => tipoZona;
      
        //Metodo Set tipoZona
        public void setTipoZona(TipoZona pZona)
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
        
        //Metodo Realizar reserva zona Especial
        public static void reservarZonaEspecial()
        {
            int temp = reservasEspecial + ingreso;
            if (reservasEspecial == Zona.capacidadEspecial)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadEspecial)
            {
                //topeZonaEspecial = true;
                int exceso = temp - Zona.capacidadEspecial;
                throw new Exception("Se excedio el cupo de la zona Especial por: " + exceso + " persona(s)");
            }
            else
            {
                reservasEspecial += ingreso;
            }
        }
        //Metodo Realizar reserva zona A
        public static void reservarZonaA()
        {
            int temp = reservasA + ingreso;
            if (reservasA == Zona.capacidadA)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadA)
            {
                int exceso = temp - Zona.capacidadA;
                throw new Exception("Se excedio el cupo de la zona A por: " + exceso + " persona(s)");
                //reservasEspecial -= exceso;
            }
            else
            {
                reservasA += ingreso;
            }
        }
        //Metodo Realizar reserva zona B
        public static void reservarZonaB()
        {
            int temp = reservasB + ingreso;

            if (reservasB == Zona.capacidadB)
            {
                throw new Exception("La Zona B ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadB)
            {
                int exceso = temp - Zona.capacidadB;
                throw new Exception("Se excedio el cupo de la Zona B por: " + exceso + " persona(s)");
            }
            else
            {
                reservasB += ingreso;
            }

        }
        //Metodo Realizar reserva zona C
        public static void reservarZonaC()
        {
            int temp = reservasC + ingreso;
            if (reservasC == Zona.capacidadC)
            {
                throw new Exception("La zona C ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadC)
            {
                int exceso = temp - Zona.capacidadC;
                throw new Exception("Se excedio el cupo de la zona C por: " + exceso + " persona(s)");
            }
            else
            {
                reservasC += ingreso;
            }

        }
        //Metodo Realizar reserva zona D
        public static void reservarZonaD()
        {
            int temp = reservasD + ingreso;

            if (reservasD == Zona.capacidadD)
            {
                throw new Exception("La Zona D ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadD)
            {
                int exceso = temp - Zona.capacidadD;

                throw new Exception("Se excedio el cupo de la Zona D por: " + exceso + " persona(s)");
            }
            else
            {
                reservasD += ingreso;
            }

        }
        //Metodo Realizar reserva zona VIP
        public static void reservarZonaVIP()
        {
            int temp = reservasVIP + ingreso;

            if (reservasVIP == Zona.capacidadVIP)
            {
                throw new Exception("La zona VIP ya se encuentra al maximo de su capacidad");
            }
            else if (temp > Zona.capacidadVIP)
            {
                int exceso = temp - Zona.capacidadVIP;
                throw new Exception("Se excedio el cupo de la zona VIP por: " + exceso + " persona(s)");
            }
            else
            {
                reservasVIP += ingreso;
            }

        }
        //Metodo Salida zona Especial
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
        //Metodo Salida zona A
        public static void salidaZonaA()
        {
            int temp = reservasA;
            int salida = reservasA - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona A Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasA
                                   + " Personas en la zona");
            }
            else
            {
                reservasA = reservasA - salidaZona;
            }
        }
        //Metodo Salida zona B
        public static void salidaZonaB()
        {
            int temp = reservasB;
            int salida = reservasB - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona B Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasB
                                  + " Personas en la zona");
            }
            else
            {
                reservasB = reservasB - salidaZona;

            }
        }
        //Metodo Salida zona C
        public static void salidaZonaC()
        {
            int temp = reservasC;
            int salida = reservasC - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona C Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasC
                                  + " Personas en la zona");
            }
            else
            {
                reservasC = reservasC - salidaZona;

            }
        }
        //Metodo Salida zona D
        public static void salidaZonaD()
        {
            int temp = reservasD;
            int salida = reservasD - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona D Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasD
                                 + " Personas en la zona");

            }
            else
            {
                reservasD = reservasD - salidaZona;

            }
        }
        //Metodo Salida zona VIP
        public static void salidaZonaVIP()
        {
            int temp = reservasVIP;
            int salida = reservasVIP - salidaZona;
            if (temp == 0)
            {
                throw new Exception("No hay personas en la zona D Actualmente");
            }
            else if (salida < 0)
            {
                throw new Exception("No se puede desalojar este numero de personas, solo hay " + reservasVIP
                                  + " Personas en la zona");

            }
            else
            {
                reservasVIP = reservasVIP - salidaZona;

            }
        }
        
        //Metodo Get NumPersonas ingresadas
        public static int darNumeroDePersonasIngresasadas()
        {
            int ingresadas = reservasEspecial + reservasA + reservasB + reservasC + reservasD + reservasVIP;
            return ingresadas;
        }
        //Metodo Get Aforo
        public static double darAforoTotal()
        {
            int totalCapacidad = Zona.darCapacidadTotal();
            int personasIngresadas = darNumeroDePersonasIngresasadas();

            double aforo = (personasIngresadas * 100) / totalCapacidad;
            return aforo;
        }
    }
}


