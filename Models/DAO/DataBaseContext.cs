using aaa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1105_1.Models.Dao
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Documento> Documentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=projetoqualyteam;Uid=root;Pwd=ahnes");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Documento>(new DocumentoMap().Configure);

        }

    }
}