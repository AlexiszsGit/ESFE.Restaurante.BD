using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;
using System.Collections.Generic;

namespace ESFE.RestauranteBD.LN
{
    public class ReservaLN
    {
        private readonly ReservaDAL reservaDAL;

        public ReservaLN()
        {
            reservaDAL =
                new ReservaDAL();
        }

        // =========================================================
        // AGREGAR
        // =========================================================

        public bool Insertar(Reserva reserva)
        {
            return reservaDAL.Insertar(reserva);
        }

        // =========================================================
        // ACTUALIZAR
        // =========================================================

        public bool Actualizar(Reserva reserva)
        {
            return reservaDAL.Actualizar(reserva);
        }

        // =========================================================
        // ELIMINAR
        // =========================================================

        public bool Eliminar(string idReserva)
        {
            return reservaDAL.Eliminar(idReserva);
        }

        // =========================================================
        // BUSCAR / MOSTRAR
        // =========================================================

        public List<Reserva> Buscar(string idReserva)
        {
            return reservaDAL.Buscar(idReserva);
        }
    }
}