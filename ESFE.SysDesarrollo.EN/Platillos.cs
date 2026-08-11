using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN

    {
        public class Platillos
        {
            public int IdPlatillo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public string Descripcion  { get; set; }
            public int IdCategoria { get; set; }
        }
}
