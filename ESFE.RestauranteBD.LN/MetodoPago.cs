using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;
using System.Collections.Generic;

namespace ESFE.RestauranteBD.LN
{
    public class MetodoPagoLN
    {
        private MetodoPago metodoPagoDAL = new MetodoPago();

        public List<MetodoDePago> Buscar(MetodoDePago pMetodo)
        {
            return metodoPagoDAL.Buscar(pMetodo);
        }

        public int Agregar(MetodoDePago pMetodo)
        {
            return metodoPagoDAL.Agregar(pMetodo);
        }

        public int Modificar(MetodoDePago pMetodo, string pIdAnterior)
        {
            return metodoPagoDAL.Modificar(pMetodo, pIdAnterior);
        }

        public int Eliminar(string pIdMetodo)
        {
            return metodoPagoDAL.Eliminar(pIdMetodo);
        }
    }
}