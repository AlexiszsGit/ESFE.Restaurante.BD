using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.LN
{
    public class PagoLN
    {
        private readonly PagoDAL pagoDAL;

        public PagoLN()
        {
            pagoDAL = new PagoDAL();
        }

        public int Agregar(Pago pPago)
        {
            return pagoDAL.Agregar(pPago);
        }

        public bool Actualizar(Pago pago)
        {
            return pagoDAL.Actualizar(pago);
        }

        public int Eliminar(string pIdPago)
        {
            return pagoDAL.Eliminar(pIdPago);
        }
        public List<Pago> Buscar(Pago pPago)
        {
            return pagoDAL.Buscar(pPago);
        }
    }
}
