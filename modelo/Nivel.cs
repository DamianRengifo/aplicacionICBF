using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionICBF.modelo
{
    internal class Nivel
    {
        ORMDataContext bd = new ORMDataContext();
        public Object consultarTodos()
        {
            return (from j in bd.nivel select j).ToList();
        }
    }
}
