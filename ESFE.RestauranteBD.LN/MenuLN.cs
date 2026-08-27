using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;
using System.Collections.Generic;

namespace ESFE.RestauranteBD.LN
{
    public class MenuLN
    {
        private readonly MenuDAL menuDAL;

        public MenuLN()
        {
            menuDAL = new MenuDAL();
        }

        public bool agregar(MenuEN menu)
        {
            return menuDAL.Agregar(menu);
        }

        public bool Actualizar(MenuEN menu)
        {
            return menuDAL.Actualizar(menu);
        }

        public bool Eliminar(MenuEN menu)
        {
            return menuDAL.Eliminar(menu);
        }

        public List<MenuEN> Buscar(MenuEN menu)
        {
            return menuDAL.Buscar(menu);
        }

        public List<MenuEN> ObtenerTodos()
        {
            return menuDAL.ObtenerTodos();
        }

        public List<Pedido> ObtenerPedidos()
        {
            return menuDAL.ObtenerPedidos();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return menuDAL.ObtenerCategorias();
        }

        public List<Postre> ObtenerPostres()
        {
            return menuDAL.ObtenerPostres();
        }

        public List<Bebida> ObtenerBebidas()
        {
            return menuDAL.ObtenerBebidas();
        }
    }
}