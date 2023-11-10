using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionICBF.modelo
{
    internal class EpsDAO
    {
        ORMDataContext bd = new ORMDataContext();
        public Object consultarTodos()
        {
            return (from j in bd.eps select j).ToList();
        }
    }
}
