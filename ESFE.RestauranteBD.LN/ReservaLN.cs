using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.LN
{
    public class ReservaLN
    {
        private readonly ReservaDAL reservaDAL;

        public ReservaLN()
        {
            reservaDAL = new ReservaDAL();
        }

        public bool Insertar(Reserva reserva)
        {
            return reservaDAL.Insertar(reserva);
        }

        public bool Actualizar(Reserva reserva)
        {
            return reservaDAL.Actualizar(reserva);
        }

        public bool Eliminar(string idReserva)
        {
            return reservaDAL.Eliminar(idReserva);
        }

        public List<Reserva> Buscar(string idReserva)
        {
            return reservaDAL.Buscar(idReserva);
        }
    }
}
