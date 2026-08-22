    using System;
    using System.Collections.Generic;
    using System.Text;
    using ESFE.RestauranteBD.DAL; 
    using ESFE.RestauranteBD.EN;  
    
    namespace ESFE.RestauranteBD.LN
    {
        public class TipoEmpleadoLN
        {
            private readonly TipoEmpleadoDAL tipoEmpleadoDAL;

            public TipoEmpleadoLN()
            {
                tipoEmpleadoDAL = new TipoEmpleadoDAL();
            }

            public bool Insertar(TipoEmpleado tipoEmpleado)
            {
                return tipoEmpleadoDAL.Insertar(tipoEmpleado);
            }

            public List<TipoEmpleado> Buscar(string idTipo)
            {
                return tipoEmpleadoDAL.Buscar(idTipo);
            }

        public bool Actualizar(TipoEmpleado tipoEmpleado, string idViejo)
        {
            return tipoEmpleadoDAL.Actualizar(tipoEmpleado, idViejo) > 0;
        }

        public bool Eliminar(string idTipo)
            {
                return tipoEmpleadoDAL.Eliminar(idTipo);
            }
        }
    }