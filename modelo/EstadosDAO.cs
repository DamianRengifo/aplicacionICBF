﻿using System;
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
            return from e in bd.estados where e.fk_idTiposEstados == 1 select e;
        }

        public Object consultarEstadosNiños()
        {
            return from e in bd.estados where e.fk_idTiposEstados == 2 select e;
        }
    }
}
