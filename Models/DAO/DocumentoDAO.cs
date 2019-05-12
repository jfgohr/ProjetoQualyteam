using aaa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1105_1.Models.Dao
{
    public class DocumentoDAO
    {
        public void Insert(Documento doc)
        {
            using (var context = new DataBaseContext())
            {
                context.Add(doc);
                context.SaveChanges();
            }
        }

        public void Delete(Documento doc)
        {
            using (var context = new DataBaseContext())
            {
                context.Remove(doc);
                context.SaveChanges();
            }
        }

        public List<Documento> SelectAll()
        {
            using (var context = new DataBaseContext())
                return context.Documentos.ToList();
        }

        public Documento DocumentoById(int id)
        {
            using (var context = new DataBaseContext())
                return context.Documentos.Where(d => d.Id == id).FirstOrDefault();
        }
    }

}