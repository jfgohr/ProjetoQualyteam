using aaa.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1105_1.Models.Dao
{
    public class DocumentoMap : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("documento");

            builder.HasKey(x => x.Id)
                .HasName("id");

            builder.Property(x => x.Titulo)
                .IsRequired()
                .HasColumnName("titulo");

            builder.Property(x => x.Processo)
                .IsRequired()
                .HasColumnName("processo");

            builder.Property(x => x.Categoria)
                .IsRequired()
                .HasColumnName("categoria");

            builder.Property(x => x.Anexo)
                .IsRequired()
                .HasColumnName("anexo");
        }
    }
}