using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
   

    public class EmpleadoLN
    {
        private readonly EmpleadoDAL empleadoDAL;

        public EmpleadoLN()
        {
            empleadoDAL = new EmpleadoDAL();
        }

        public bool Insertar(Empleado empleado)
        {
            return empleadoDAL.Insertar(empleado);
        }

        public bool Actualizar(Empleado pEmpleado, string idViejo)
        {
            return empleadoDAL.Actualizar(pEmpleado, idViejo) > 0;
        }

        public bool Eliminar(string idEmpleado)
        {
            return empleadoDAL.Eliminar(idEmpleado);
        }

        public List<Empleado> Buscar(string idEmpleado)
        {
            return empleadoDAL.Buscar(idEmpleado);
        }
    }
}