using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Usuarios usuarios)
        {
            if (!Existe(usuarios.UsuarioId))
                return Insertar(usuarios);
            else
            {
                return Modificar(usuarios);
            }
        }

        private static bool Insertar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Usuarios.Add(usuarios);
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Usuarios usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(usuarios).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Usuarios.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static Usuarios Buscar(int id)
        {

            Contexto db = new Contexto();
            Usuarios usuarios = new Usuarios();

            try
            {
                usuarios = db.Usuarios.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return usuarios;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Usuarios.Any(a => a.UsuarioId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;
        }
    }
}
