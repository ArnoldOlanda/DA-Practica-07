using Exp_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exp_3.datos
{
    public class CustomerAdmin
    {
        public IEnumerable<CLIENTES> Consultar()
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.CLIENTES.AsNoTracking().ToList();
            }
        }
        public CLIENTES Consultar(int id)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.CLIENTES.AsNoTracking().FirstOrDefault(c =>
               c.codigo == id);
            }
        }

        public void Guardar(CLIENTES modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.CLIENTES.Add(modelo);
                contexto.SaveChanges();
            }
        }

        public void Modificar(CLIENTES modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }
        public void Eliminar(CLIENTES modelo)
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