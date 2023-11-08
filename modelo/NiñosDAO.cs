using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionICBF.modelo
{
    public class NiñosDAO
    {
        ORMDataContext bd = new ORMDataContext();

        public Object consultarNiños() {
            return (from j in bd.niños select j).ToList();
        }

        public void registrarNiños(niños niño)
        {
            bd.niños.InsertOnSubmit(niño);
            bd.SubmitChanges();
        }
    }
}
