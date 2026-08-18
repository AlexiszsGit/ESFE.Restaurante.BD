using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESFE.RestauranteBD.LN
{
    public class pedidoLN
    {
        private readonly PedidoDAL pedidoDAL;

        public pedidoLN()
        {
            pedidoDAL = new PedidoDAL();
        }

        public bool Insertar(Pedido pedido)
        {
            return pedidoDAL.Insertar(pedido);
        }

        public bool Actualizar(Pedido pedido)
        {
            return pedidoDAL.Actualizar(pedido);
        }

        public bool Eliminar(string idPedido)
        {
            return pedidoDAL.Eliminar(idPedido);
        }

        public List<Pedido> Buscar(string idPedido)
        {
            return pedidoDAL.Buscar(idPedido);
        }
    }
}
