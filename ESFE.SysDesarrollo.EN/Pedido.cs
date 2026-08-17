using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN
{
    public class Pedido
    {
        public string IdPedido { get; set; }
        public DateTime fecha { get; set; }
        public string IDCliente { get; set; }
        public string IdEmpleado { get; set; }
        public string IdMesa { get; set; }
        public string IdEstado { get; set; }
    }
}
