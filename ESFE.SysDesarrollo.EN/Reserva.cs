using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN
{
    internal class Reserva
    {
        public string IdReserva { get; set; }
        public DateTime fechaReserva { get; set; }
        public string Hora { get; set; }
        public int Personas { get; set; }
        public string IdCliente { get; set; }
        public string IdMesa { get; set; }fff
    }
}
