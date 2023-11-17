﻿using System;
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
            return (from j in bd.usuarios where j.fk_idRol == 1 
                    select new
                    {
                        Codigo = j.idUsuario,
                        nombre = j.nombre,
                        identificacion = j.numIdentificacion,
                        telefono = j.telefono,
                        celular = j.celular, 
                        direccion = j.direccion,
                        Correo = j.email,
                    }
                    ).ToList();
        }

        public void registrarAcudiente(usuarios acudiente)
        {
            acudiente.fk_idRol = 1;
            bd.usuarios.InsertOnSubmit(acudiente);
            bd.SubmitChanges();
        }

        public Object consultarMadreComunitaria() {
            return (from j in bd.usuarios
                    where j.fk_idRol == 2
                    select new
                    {
                        Codigo = j.idUsuario,
                        nombre = j.nombre,
                        Identificacion = j.numIdentificacion,
                        celular = j.celular, 
                        direccion = j.direccion,
                        fechaNacimiento = j.fechaNacimiento,

                    }).ToList();
        }

        public void actualizarAcudiente(usuarios acudiente)
        {
            usuarios acudienteEdit = (from j in bd.usuarios
                                  where j.idUsuario == acudiente.idUsuario
                                  select j).FirstOrDefault();
            acudienteEdit.nombre = acudiente.nombre;
            acudienteEdit.numIdentificacion = acudiente.numIdentificacion;
            acudienteEdit.celular = acudiente.celular;
            acudienteEdit.telefono = acudiente.telefono;
            acudienteEdit.direccion = acudiente.direccion;
            acudienteEdit.fechaNacimiento = acudiente.fechaNacimiento;
            acudienteEdit.email = acudiente.email;
            if (!string.IsNullOrWhiteSpace(acudiente.clave))
            {
                acudienteEdit.clave = acudiente.clave;
            }

            bd.SubmitChanges();
        }

        public void registrarMadre(usuarios madre) {
            madre.fk_idRol = 2;
            bd.usuarios.InsertOnSubmit(madre);
            bd.SubmitChanges();
        }

        public void actualizarMadre(usuarios madre)
        {
            usuarios madreEdit = (from j in bd.usuarios 
                                  where j.idUsuario == madre.idUsuario select j).FirstOrDefault();
            madreEdit.nombre = madre.nombre;
            madreEdit.numIdentificacion = madre.numIdentificacion;
            madreEdit.celular = madre.celular;
            madreEdit.direccion = madre.direccion;
            madreEdit.fechaNacimiento = madre.fechaNacimiento;
            if (!string.IsNullOrWhiteSpace(madre.clave))
            {
                madreEdit.clave = madre.clave;
            }

            bd.SubmitChanges();
        }

        public void eliminarUsuario(int idUsuario) {
            usuarios madreEdit = (from j in bd.usuarios
                                  where j.idUsuario == idUsuario
                                  select j).FirstOrDefault();

            bd.usuarios.DeleteOnSubmit(madreEdit);
            bd.SubmitChanges();
        }
        public Object consultarAdmin()
        {
            return (from j in bd.usuarios where j.fk_idRol == 3 select j).ToList();
        }

    }
}
