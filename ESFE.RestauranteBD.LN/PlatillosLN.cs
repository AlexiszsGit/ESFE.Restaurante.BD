using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
   

    public class PlatillosLN
    {
        private readonly PlatillosDAL platillosDAL;

        public PlatillosLN()
        {
            platillosDAL = new PlatillosDAL();
        }

        public bool Insertar(Platillo platillo)
        {
            return platillosDAL.Insertar(platillo);
        }

        public bool Actualizar(Platillo platillo)
        {
            return platillosDAL.Actualizar(platillo);
        }

        public bool Eliminar(string idProducto)
        {
            return platillosDAL.Eliminar(idProducto);
        }

        public List<Platillo> Buscar(string idProducto)
        {
            return platillosDAL.Buscar(idProducto);
        }
    }
}