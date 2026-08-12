using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.EN
{
    public class Empleado
    {
        
            public int IdEmpleado { get; set; }
            public int IdTipoEmpleado { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string Estado { get; set; }
    }
}
