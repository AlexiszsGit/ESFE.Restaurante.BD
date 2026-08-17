using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
    public class DescuentosLN
    {
        private readonly DescuentosDAL descuentosDAL;

        public DescuentosLN()
        {
            descuentosDAL = new DescuentosDAL();
        }

        public bool Insertar(Descuentos descuento)
        {
            return descuentosDAL.Insertar(descuento);
        }

        public List<Descuentos> Buscar(string nombre)
        {
            return descuentosDAL.Buscar(nombre);
        }

        public List<Descuentos> BuscarPorNombre(string nombre)
        {
            return descuentosDAL.BuscarPorNombre(nombre);
        }

        public bool Actualizar(Descuentos descuento)
        {
            return descuentosDAL.Actualizar(descuento);
        }

        public bool Eliminar(string idDescuento)
        {
            return descuentosDAL.Eliminar(idDescuento);
        }
    }
}