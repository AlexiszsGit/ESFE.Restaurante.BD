using System.Collections.Generic;
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


        public bool Actualizar(
            Descuentos descuento,
            string idAnterior)
        {
            return descuentosDAL.Actualizar(
                descuento,
                idAnterior);
        }


        public bool Eliminar(string idDescuento)
        {
            return descuentosDAL.Eliminar(idDescuento);
        }


        public List<Descuentos> Buscar(string texto)
        {
            return descuentosDAL.Buscar(texto);
        }


        public List<Descuentos> BuscarPorNombre(string nombre)
        {
            return descuentosDAL.BuscarPorNombre(nombre);
        }
    }
}