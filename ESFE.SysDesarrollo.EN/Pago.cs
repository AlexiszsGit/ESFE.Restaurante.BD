using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN
{
    public class Pago
    {
        public string IdPago { get; set; }
        public decimal total { get; set; }
        public DateTime fechaPago { get; set; }
        public string IdMetodo { get; set; }
        public string IdPedido { get; set; }
    }
}
