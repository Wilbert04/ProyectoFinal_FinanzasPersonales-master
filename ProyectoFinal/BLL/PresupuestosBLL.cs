using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class PresupuestosBLL
    {
        public static bool Guardar(Presupuestos presupuestos)
        {
            if (!Existe(presupuestos.PresupuestoId))
                return Insertar(presupuestos);
            else
            {
                return Modificar(presupuestos);
            }
        }

        private static bool Insertar(Presupuestos presupuestos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Presupuestos.Add(presupuestos);
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

        public static bool Modificar(Presupuestos presupuestos)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(presupuestos).State = EntityState.Modified;
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
                var eliminar = db.Presupuestos.Find(id);
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


        public static Presupuestos Buscar(int id)
        {

            Contexto db = new Contexto();
            Presupuestos presupuestos = new Presupuestos();

            try
            {
                presupuestos = db.Presupuestos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return presupuestos;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Presupuestos.Any(a => a.PresupuestoId == id);
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

