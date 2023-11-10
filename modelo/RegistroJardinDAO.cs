using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionICBF.modelo
{
    public class RegistroJardinDAO
    {
        ORMDataContext bd = new ORMDataContext();

        public void registrar(registro_jardin jardin)
        {
            bd.registro_jardin.InsertOnSubmit(jardin);
            bd.SubmitChanges();
        }

        public void editar(registro_jardin jardin)
        {
            registro_jardin jardinEditar = (from j in bd.registro_jardin
                                            where j.idJardin == jardin.idJardin
                                            select j).FirstOrDefault();
            jardinEditar.nomJardin = jardin.nomJardin;
            jardinEditar.direccionJardin = jardin.direccionJardin;
            jardinEditar.fk_idEstado = jardin.fk_idEstado;
            bd.SubmitChanges();
        }

        public void eliminar(int idJardin)
        {
            registro_jardin JardinEliminar = (from j in bd.registro_jardin
                                              where j.idJardin == idJardin
                                              select j).FirstOrDefault();
            bd.registro_jardin.DeleteOnSubmit(JardinEliminar);
            bd.SubmitChanges();
        }

        public Object consultarTodos()
        {
            return (from j in bd.registro_jardin select j).ToList();
        }
    }
}
