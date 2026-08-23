using System;
using System.Collections.Generic;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.BL
{
    public class MesaLN
    {
        private readonly MesaDAL mesaDAL;

        public MesaLN()
        {
            mesaDAL = new MesaDAL();
        }

        public bool Insertar(Mesa mesa)
        {
            return mesaDAL.Insertar(mesa);
        }

        public bool Actualizar(Mesa mesa)
        {
            return mesaDAL.Modificar(mesa);
        }

        public bool Eliminar(string idMesa)
        {
            return mesaDAL.Eliminar(idMesa);
        }

        public List<Mesa> Buscar(string idMesa)
        {
            return mesaDAL.Buscar(idMesa);
        }

        public List<Mesa> ObtenerMesas()
        {
            return mesaDAL.ObtenerMesas();
        }
    }
}