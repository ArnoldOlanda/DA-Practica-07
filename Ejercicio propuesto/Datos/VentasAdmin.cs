using EjerciciosPropuestos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjerciciosPropuestos.Datos
{
    public class VentasAdmin
    {
        public IEnumerable<VENTAS> Consultar()
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.VENTAS.AsNoTracking().ToList();
            }
        }
        public VENTAS Consultar(int id)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.VENTAS.AsNoTracking().FirstOrDefault(c =>
               c.codventa == id);
            }
        }
        public void Guardar(VENTAS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.VENTAS.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(VENTAS modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(VENTAS modelo)
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