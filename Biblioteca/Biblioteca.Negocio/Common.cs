using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;

namespace Biblioteca.Negocio
{
    public class Common
    {
        private static TiendaEntities _tiendaEntidad;
        public static TiendaEntities TiendaEntidad
        {
            get
            {
                if (_tiendaEntidad == null)
                {
                    _tiendaEntidad = new TiendaEntities();
                }
                return _tiendaEntidad;
            }
        }
        public Common() { }
    }
}
