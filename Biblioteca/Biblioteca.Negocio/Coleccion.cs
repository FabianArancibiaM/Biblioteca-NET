using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;
using System.Runtime.Serialization;

namespace Biblioteca.Negocio
{
    [DataContract]
    public class Coleccion
    {
        private List<Cliente> generarList(List<DALC.cliente> listaDALC)
        {
            List<Negocio.Cliente> listaCliente = new List<Cliente>();
            foreach (var i in listaDALC)
            {
                Cliente c = new Cliente();
                c.id = i.id;
                c.nombre = i.nombre;
                c.edad = i.edad;
                listaCliente.Add(c);
            }
            return listaCliente;
        }
        public List<Cliente> leerTodo()
        {
            var lista = Common.TiendaEntidad.cliente.ToList();
            return generarList(lista);
        }
    }
}
