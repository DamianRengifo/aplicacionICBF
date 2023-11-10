using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace aplicacionICBF.modelo
{
    public class EstadosDAO
    {
        ORMDataContext bd = new ORMDataContext();
        public Object consultarTodos()
        {
            return from e in bd.estados select e;
        }
    }
}
