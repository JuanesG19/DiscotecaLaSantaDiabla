using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    public  class Zona
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

        public static int capacidadEspecial = 60;
        public static int capacidadA = 30;
        public static int capacidadB = 30;
        public static int capacidadC = 30;
        public static int capacidadD = 30;
        public static int capacidadVIP = 30;

        public static int darCapacidadTotal()
        {
            int capacidad = capacidadVIP+ capacidadEspecial+ capacidadA+ capacidadB+ capacidadC+ capacidadD;
            return capacidad;
        }
    }
}
