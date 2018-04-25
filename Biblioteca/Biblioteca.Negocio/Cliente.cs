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
    public class Cliente 
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string nombre { get; set; }
        [DataMember]
        public int edad { get; set; }

        public Cliente() { }

        public bool create()
        {
            try
            {
                if (!(existe(id)==true))
                {
                    DALC.cliente c = new DALC.cliente();
                    c.edad = this.edad;
                    c.nombre = this.nombre;
                    c.id = this.id;
                    Common.TiendaEntidad.cliente.Add(c);
                    Common.TiendaEntidad.SaveChanges();
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        private bool existe(int id)
        {
            return Common.TiendaEntidad.cliente.Count(c => c.id == id)==1;
        }

        public bool read(int id)
        {
            try
            {
                DALC.cliente c = Common.TiendaEntidad.cliente.SingleOrDefault(cl => cl.id == id);
                this.id = c.id;
                this.nombre = c.nombre;
                this.edad = c.edad;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool update(Cliente cliente)
        {
            try
            {
                DALC.cliente cl = Common.TiendaEntidad.cliente.SingleOrDefault(c => c.id == cliente.id);
                cl.nombre = cliente.nombre;
                cl.edad = cliente.edad;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool delete(int id)
        {
            try
            {
                DALC.cliente c = Common.TiendaEntidad.cliente.SingleOrDefault(cl => cl.id == id);
                Common.TiendaEntidad.cliente.Remove(c);
                Common.TiendaEntidad.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
