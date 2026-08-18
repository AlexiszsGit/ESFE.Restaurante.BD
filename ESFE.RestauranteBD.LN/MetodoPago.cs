using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;   
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.LN
{
    public class MetodoPago
    {
        private readonly MetodoPago metodoDePagoDAL;

        public MetodoPago()
        {
           metodoDePagoDAL = new MetodoPago();
        }

        public bool Insertar(MetodoDePago metodo)
        {
            return metodoDePagoDAL.Insertar(metodo);
        }

        public bool Actualizar(MetodoDePago metodo)
        {
            return metodoDePagoDAL.Actualizar(metodo);
        }

        public bool Eliminar(string idMetodoDePago)
        {
            return metodoDePagoDAL.Eliminar(idMetodoDePago);
        }

        public List<MetodoDePago> Buscar(string nombre)
        {
            return metodoDePagoDAL.Buscar(nombre);
        }
    }
}
