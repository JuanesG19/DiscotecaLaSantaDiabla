using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    public class Zona
    {
        private int idZona;
        private String tipoZona;
        private int capacidadMaxima;
        private int capacidaActual;

        public Zona(int idZona, string tipoZona, int capacidadMaxima, int capacidaActual)
        {
            this.idZona = idZona;
            this.tipoZona = tipoZona;
            this.capacidadMaxima = capacidadMaxima;
            this.capacidaActual = capacidaActual;
        }

        public int getIdZona() => idZona;

        public void setIdZona(int pTipoZona)
        {
            idZona = pTipoZona;
        }
        public string getTipoZona() => tipoZona;

        public void setTipoZona(String pTipoZona)
        {
            tipoZona = pTipoZona;
        }

        public int getCapacidadMaxima() => capacidadMaxima;

        public void setCapacidadMaxima(int pCapacidadMaxima)
        {
            capacidadMaxima = pCapacidadMaxima;
        }
        public int getCapacidaActual() => capacidaActual;

        public void setCapacidadActual(int pCapacidadActual)
        {
            capacidaActual = pCapacidadActual;
        }

    }
}
