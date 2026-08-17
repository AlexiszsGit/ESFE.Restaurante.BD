using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<DetallePedidos> Buscar(string idPedido)
        {
            return detallePedidosDAL.Buscar(idPedido);
        }

        public List<DetallePedidos> BuscarPorPedido(string idPedido)
        {
            return detallePedidosDAL.BuscarPorPedido(idPedido);
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
