using System;
using System.Collections.Generic;
using System.Text;

namespace DiscotecaLaSantaDiabla.logica
{
    class Factura
    {
        private String id_factura;
        private String id_usuario;
        private String nombre_usuario;
        private String apellido_usuario;
        private String telefono_usuario;
        private String nombre_bebida;
        private int cantidad_bebida;
        private double precio_subtotal;
        private double precio_total;
        private String fecha_factura;

        public Factura(string id_factura, string id_usuario, string nombre_usuario, string apellido_usuario, string telefono_usuario, string nombre_bebida, int cantidad_bebida, double precio_subtotal, double precio_total, string fecha_factura)
        {
            this.id_factura = id_factura;
            this.id_usuario = id_usuario;
            this.nombre_usuario = nombre_usuario;
            this.apellido_usuario = apellido_usuario;
            this.telefono_usuario = telefono_usuario;
            this.nombre_bebida = nombre_bebida;
            this.cantidad_bebida = cantidad_bebida;
            this.precio_subtotal = precio_subtotal;
            this.precio_total = precio_total;
            this.fecha_factura = fecha_factura;
        }

        public string getIdFactura() => id_factura;

        public void setIdfactura(String pID)
        {
            id_factura = pID;
        }

        public string getIdUsuario() => id_usuario;

        public void setID(String pIdUsuario)
        {
            id_usuario = pIdUsuario;
        }

        public string getNombreUsuario() => nombre_usuario;

        public void setNombreUsuario(String pNombreUsuario)
        {
            nombre_usuario = pNombreUsuario;
        }
        public string getApellidoUsuario() => apellido_usuario;

        public void setApellidoUsuario(String pApellidoUsuario)
        {
            apellido_usuario = pApellidoUsuario;
        }

        public string getTelefonoUsuario() => telefono_usuario;

        public void setTelefonoUsuario(String pTelefonoUsuario)
        {
            telefono_usuario = pTelefonoUsuario;
        }

        public string getNombreBebida() => nombre_bebida;

        public void setNombreBebida(String pNombreBebida)
        {
            nombre_bebida = pNombreBebida;
        }

        public int getCantidadBebida()=> cantidad_bebida;

        public void setCantidadBebida(int pCantidadBebida)
        {
            cantidad_bebida = pCantidadBebida;
        }

        public double getPrecioSubtotal() => precio_subtotal; 

        public void setPrecioSubtotal(double pPrecioBubtotal)
        {
            precio_subtotal = pPrecioBubtotal;
        }

        public double getPrecioTotal() => precio_total;

        public void setPrecioTotal(double pPrecioTotal)
        {
            precio_total = pPrecioTotal;
        }

        public string getFechaFactura() => fecha_factura;

        public void setFechaFactura(String pFechaFactura)
        {
            fecha_factura = pFechaFactura;
        }

        //Lista facturas

        private static List<Factura> facturas = new List<Factura>();

        public static List<Factura> getFacturas() => facturas;

         //Metodo agregar Factura
        public static void agregarFactura(Factura pFactura)
        {
            facturas.Add(pFactura); 
        }

        public static void limpiarListaFacturas()
        {
            for (int i = 0; i < facturas.Count; i++)
            {
                facturas.RemoveAt(i);
                i--;
            }
        }



    }
}
