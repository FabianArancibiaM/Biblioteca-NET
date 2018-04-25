using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Biblioteca.Negocio;

namespace Biblioteca.WcfService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ColeccionS" en el código y en el archivo de configuración a la vez.
    public class ColeccionS : IColeccionS
    {
        public List<Cliente> leerTodo()
        {
            Negocio.Coleccion c = new Negocio.Coleccion();
            return c.leerTodo();
        }
    }
}
