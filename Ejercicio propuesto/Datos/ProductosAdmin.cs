using EjerciciosPropuestos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjerciciosPropuestos.Datos
{
    public class ProductosAdmin
    {
        public IEnumerable<PRODUCTOS> Consultar()
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.PRODUCTOS.AsNoTracking().ToList();
            }
        }
        public PRODUCTOS Consultar(int id)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.PRODUCTOS.AsNoTracking().FirstOrDefault(c =>
               c.codpro == id);
            }
        }
        public void Guardar(PRODUCTOS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.PRODUCTOS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(PRODUCTOS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(PRODUCTOS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }
    }
}