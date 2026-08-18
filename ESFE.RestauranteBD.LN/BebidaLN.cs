using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
    public class BebidaLN
    {
        private readonly BebidaDAL bebidaDAL;

        public BebidaLN()
        {
            bebidaDAL = new BebidaDAL();
        }

        public bool Insertar(Bebida bebida)
        {
            return bebidaDAL.Insertar(bebida);
        }

        public List<Bebida> Buscar(string nombre)
        {
            return bebidaDAL.Buscar(nombre);
        }

        public List<Bebida> BuscarPorNombre(string nombre)
        {
            return bebidaDAL.BuscarPorNombre(nombre);
        }

        public bool Actualizar(Bebida bebida)
        {
            return bebidaDAL.Actualizar(bebida);
        }

        public bool Eliminar(string idBebida)
        {
            return bebidaDAL.Eliminar(idBebida);
        }
    }
}