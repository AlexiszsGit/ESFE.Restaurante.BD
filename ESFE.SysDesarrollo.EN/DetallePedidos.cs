using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN
{
    public class DetallePedidos
    {
        public string IdDetalle { get; set; }
        public string? IdPedido { get; set; }
        public int Cantidad { get; set; }
    }
}
