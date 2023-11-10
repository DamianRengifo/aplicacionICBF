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

        public void editarNiño(niños niño) {
            niños niñoEdit = (from j in bd.niños where j.idNiño == niño.idNiño select j).FirstOrDefault();
            niñoEdit.nombre = niño.nombre;
            niñoEdit.numIdentificacion = niño.numIdentificacion;
            niñoEdit.telefonoNiño = niño.telefonoNiño;
            niñoEdit.direccionNiño = niño.direccionNiño;
            niñoEdit.ciudad_nacimiento = niño.ciudad_nacimiento;
            niñoEdit.fk_idEps = niño.fk_idEps;
            niñoEdit.fk_idTipSangre = niño.fk_idTipSangre;
            niñoEdit.fk_idAcudiente = niño.fk_idAcudiente;
            niñoEdit.fk_idJardin = niño.fk_idJardin;
            niñoEdit.fechaNac = niño.fechaNac;
        }

        public void eliminarNiño(int idNiño) {
            niños niñoEliminar = (from j in bd.niños where j.idNiño == idNiño select j).FirstOrDefault();
            bd.niños.DeleteOnSubmit(niñoEliminar);
            bd.SubmitChanges();
        }
    }
}
