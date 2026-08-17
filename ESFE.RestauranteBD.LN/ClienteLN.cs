using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.LN
{
    public class ClienteLN
    {
        private readonly ClienteDAL clienteDAL;

        public ClienteLN()
        {
            clienteDAL = new ClienteDAL();
        }

        public bool Insertar(Cliente cliente)
        {
            return clienteDAL.Insertar(cliente);
        }

        public List<Cliente> Buscar(string nombre)
        {
            return clienteDAL.Buscar(nombre);
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            return clienteDAL.BuscarPorNombre(nombre);
        }

        public bool Actualizar(Cliente cliente)
        {
            return clienteDAL.Actualizar(cliente);
        }

        public bool Eliminar(string idCliente)
        {
            return clienteDAL.Eliminar(idCliente);
        }
    }
}