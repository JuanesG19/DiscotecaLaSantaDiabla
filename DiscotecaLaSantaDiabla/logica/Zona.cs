using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Zona
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

        public TipoZona zona;


        public Zona(TipoZona pZona)
        {
            this.zona = pZona;
        }

        public TipoZona GetTipoZona()
        {
            return zona;
        }
        public void setTipoZona(TipoZona pZona)
        {
            zona = pZona;
        }




    }
}
