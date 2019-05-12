using System.Collections.Generic;
using System.Linq;

namespace ProjetoQualyteam.Models.Dao
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

        public bool Exists(int id)
        {
            using (var context = new DataBaseContext())
                return context.Documentos.Where(d => d.Id == id).FirstOrDefault() != null ? true : false;
        }
    }

}