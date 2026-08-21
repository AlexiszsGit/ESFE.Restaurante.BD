using System;

namespace ESFE.RestauranteBD.EN
{
    public class DetallePedidos
    {
        public string IdDetalle { get; set; } = string.Empty;

        public string IdPedido { get; set; } = string.Empty;

        public string IdProducto { get; set; } = string.Empty;

        public string NombreProducto { get; set; } = string.Empty;

        public int Cantidad { get; set; }
    }
}