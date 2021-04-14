using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Reserva
    {
        public int reservasEspecial;
        public int reservasA;
        public int reservasB;
        public int reservasC;
        public int reservasD;
        public int reservasPalco;

        public Reserva(int pReservasEspecial, int pReservasA, int pReservasB, int pReservasC, int pReservasD, int pReservasPalco)
        {
            reservasEspecial = pReservasEspecial;
            reservasA = pReservasA;
            reservasB = pReservasB;
            reservasC = pReservasC;
            reservasD = pReservasD;
            reservasPalco = pReservasPalco;
        }

        public int darNumReservasEspecial()
        {
            return reservasEspecial;
        }

        public int darNumReservasA()
        {
            return reservasA;
        }

        public int darNumReservasB()
        {
            return reservasB;
        }

        public int darNumReservasC()
        {
            return reservasC;
        }

        public int darNumReservasD()
        {
            return reservasD;
        }

        public int darNumReservasPalco()
        {
            return reservasPalco;
        }
        //REALIZAR RESERVAS

        public void reservarZonaEspecial(int numeroPersonas)
        {
            if (reservasEspecial + numeroPersonas <= Zona.CAPACIDAD_ESPECIAL)
            {
                reservasEspecial = reservasEspecial + numeroPersonas;

            }
            else if (reservasEspecial == Zona.CAPACIDAD_ESPECIAL)
            {
                throw new Exception("La zona especial ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasEspecial + numeroPersonas - Zona.CAPACIDAD_ESPECIAL;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona especial");

            }
        }

        public void reservarZonaA(int numeroPersonas)
        {
            if (reservasA + numeroPersonas <= Zona.CAPACIDAD_A)
            {
                reservasA = reservasA + numeroPersonas;

            }
            else if (reservasA == Zona.CAPACIDAD_A)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasA + numeroPersonas - Zona.CAPACIDAD_A;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona A");

            }
        }

        public void reservarZonaB(int numeroPersonas)
        {
            if (reservasB + numeroPersonas <= Zona.CAPACIDAD_B)
            {
                reservasB = reservasB + numeroPersonas;

            }
            else if (reservasB == Zona.CAPACIDAD_B)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasB + numeroPersonas - Zona.CAPACIDAD_B;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona B");

            }
        }

        public void reservarZonaC(int numeroPersonas)
        {
            if (reservasC + numeroPersonas <= Zona.CAPACIDAD_C)
            {
                reservasC = reservasC + numeroPersonas;

            }
            else if (reservasC == Zona.CAPACIDAD_C)
            {
                throw new Exception("La zona C ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasC + numeroPersonas - Zona.CAPACIDAD_C;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona C");

            }
        }

        public void reservarZonaD(int numeroPersonas)
        {
            if (reservasD + numeroPersonas <= Zona.CAPACIDAD_D)
            {
                reservasD = reservasD + numeroPersonas;

            }
            else if (reservasD == Zona.CAPACIDAD_D)
            {
                throw new Exception("La zona D ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasD + numeroPersonas - Zona.CAPACIDAD_D;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona D");

            }
        }

        public void reservarZonaPalco(int numeroPersonas)
        {
            if (reservasPalco + numeroPersonas <= Zona.CAPACIDAD_PALCO)
            {
                reservasPalco = reservasPalco + numeroPersonas;

            }
            else if (reservasPalco == Zona.CAPACIDAD_PALCO)
            {
                throw new Exception("La zona A ya se encuentra al maximo de su capacidad");
            }
            else
            {
                int capacidadRestante = reservasPalco + numeroPersonas - Zona.CAPACIDAD_PALCO;
                throw new Exception("Solo quedan " + capacidadRestante + " cupos disponibles en la zona B");

            }
        }
    }
}
