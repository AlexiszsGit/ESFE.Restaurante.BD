using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
    public class CategoriaLN
    {
        private readonly CategoriaDAL categoriaDAL;

        public CategoriaLN()
        {
            categoriaDAL = new CategoriaDAL();
        }

        public bool Insertar(Categoria categoria)
        {
            return categoriaDAL.Insertar(categoria);
        }

        public List<Categoria> Buscar(string nombre)
        {
            return categoriaDAL.Buscar(nombre);
        }

        public List<Categoria> BuscarPorNombre(string nombre)
        {
            return categoriaDAL.BuscarPorNombre(nombre);
        }

        public bool Actualizar(Categoria categoria)
        {
            return categoriaDAL.Actualizar(categoria);
        }

        public bool Eliminar(string idCategoria)
        {
            return categoriaDAL.Eliminar(idCategoria);
        }
    }
}