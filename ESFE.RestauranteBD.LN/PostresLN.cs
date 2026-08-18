using System;
using System.Collections.Generic;
using System.Text;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{

    public class PostreLN
    {
        private readonly PostreDAL postresDAL;

        public PostreLN()
        {
            postresDAL = new PostreDAL();
        }

        public bool Insertar(Postre postre)
        {
            return postresDAL.Insertar(postre);
        }

        public bool Actualizar(Postre postre)
        {
            return postresDAL.Actualizar(postre);
        }

        public bool Eliminar(string idPostre)
        {
            return postresDAL.Eliminar(idPostre);
        }

        public List<Postre> Buscar(string idPostre)
        {
            return postresDAL.Buscar(idPostre);
        }
    }
}