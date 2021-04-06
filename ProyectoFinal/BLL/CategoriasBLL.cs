using Microsoft.EntityFrameworkCore;
using ProyectoFinal.DAL;
using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProyectoFinal.BLL
{
    public class CategoriasBLL
    {

        public static bool Guardar(Categorias categorias)
        {
            if (!Existe(categorias.CategoriaId))
                return Insertar(categorias);
            else
            {
                return Modificar(categorias);
            }
        }

        private static bool Insertar(Categorias categorias)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Categorias.Add(categorias);
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

        public static bool Modificar(Categorias categorias)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(categorias).State = EntityState.Modified;
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
                var eliminar = db.Categorias.Find(id);
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


        public static Categorias Buscar(int id)
        {

            Contexto db = new Contexto();
            Categorias categorias = new Categorias();

            try
            {
                categorias = db.Categorias.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return categorias;
        }

        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.Categorias.Any(a => a.CategoriaId == id);
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

        public static List<Categorias> GetList(Expression<Func<Categorias, bool>> expression)
        {
            List<Categorias> lista = new List<Categorias>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Categorias.Where(expression).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}

