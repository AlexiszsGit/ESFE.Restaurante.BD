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

        public bool Insertar(Menu menu)
        {
            return menuDAL.Insertar(menu);
        }

        public bool Actualizar(Menu menu)
        {
            return menuDAL.Actualizar(menu);
        }

        public bool Eliminar(string idPedido)
        {
            return menuDAL.Eliminar(idPedido);
        }

        public List<Menu> Buscar(string idPedido)
        {
            return menuDAL.Buscar(idPedido);
        }
    }
}
