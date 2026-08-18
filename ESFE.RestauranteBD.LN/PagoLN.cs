using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.LN
{
    internal class PagoLN
    {
        private readonly PagoDAL pagoDAL;

        public PagoLN()
        {
            pagoDAL = new PagoDAL();
        }

        public bool Insertar(Pago pago)
        {
            return pagoDAL.Insertar(pago);
        }

        public bool Actualizar(Pago pago)
        {
            return pagoDAL.Actualizar(pago);
        }

        public bool Eliminar(string idPago)
        {
            return pagoDAL.Eliminar(idPago);
        }

        public List<Pago> Buscar(string idPago)
        {
            return pagoDAL.Buscar(idPago);
        }
    }
}
