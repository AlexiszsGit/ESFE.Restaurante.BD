using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;
using System;
using System.Collections.Generic;
using System.Text;

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

        public bool Eliminar(MenuEN pMenu)
        {
            return menuDAL.Eliminar(pMenu);
        }
        

        public List<MenuEN> Buscar(string idPedido)
        {
            return menuDAL.Buscar(idPedido);
        }
    }
}
