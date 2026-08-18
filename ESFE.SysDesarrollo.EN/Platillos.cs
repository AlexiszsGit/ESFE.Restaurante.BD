using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN

    {
        public class Platillo
        {
            public string IdProducto { get; set; } = string.Empty;
            public string Nombre { get; set; } = string.Empty;
            public decimal Precio { get; set; } = 0;
            public string IdCategoria { get; set; } = string.Empty;
            public string IdDescuento { get; set; } = string.Empty;
        }
}
