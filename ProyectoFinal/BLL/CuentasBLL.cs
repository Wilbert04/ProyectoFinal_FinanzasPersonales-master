using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class CuentasBLL
    {
        public static bool Guardar(Cuentas cuentas)
        {
            if (!Existe(cuentas.CuentaId))
                return Insertar(cuentas);
            else
            {
                return Modificar(cuentas);
            }
        }

        private static bool Insertar(Cuentas cuentas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Cuentas.Add(cuentas);
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

        public static bool Modificar(Cuentas cuentas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(cuentas).State = EntityState.Modified;
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
                var eliminar = db.Cuentas.Find(id);
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


        public static Cuentas Buscar(int id)
        {

            Contexto db = new Contexto();
            Cuentas cuentas  = new Cuentas();

            try
            {
                cuentas = db.Cuentas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return cuentas;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Cuentas.Any(a => a.CuentaId == id);
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
