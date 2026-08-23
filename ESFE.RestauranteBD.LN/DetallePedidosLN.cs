using System.Collections.Generic;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
    public class DetallePedidosLN
    {
        private readonly DetallePedidosDAL detallePedidosDAL;

        public DetallePedidosLN()
        {
            detallePedidosDAL = new DetallePedidosDAL();
        }

        public bool Insertar(DetallePedidos detalle)
        {
            return detallePedidosDAL.Insertar(detalle);
        }

        public List<DetallePedidos> Buscar(string busqueda)
        {
            return detallePedidosDAL.Buscar(busqueda);
        }

        public bool Actualizar(DetallePedidos detalle)
        {
            return detallePedidosDAL.Actualizar(detalle);
        }

        public bool Eliminar(string idDetalle)
        {
            return detallePedidosDAL.Eliminar(idDetalle);
        }
    }
}