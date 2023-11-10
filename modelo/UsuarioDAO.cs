using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionICBF.modelo
{
    internal class UsuarioDAO
    {
        ORMDataContext bd = new ORMDataContext();

        public Object consultarAcudiente() {
            return (from j in bd.usuarios where j.fk_idRol == 1 select j).ToList();
        }

        public Object consultarAdmin()
        {
            return (from j in bd.usuarios where j.fk_idRol == 3 select j).ToList();
        }

        public Object consultarMadreComunitaria()
        {
            return (from j in bd.usuarios where j.fk_idRol == 2 select j).ToList();
        }
    }
}
