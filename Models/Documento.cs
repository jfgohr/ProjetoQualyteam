using System.ComponentModel.DataAnnotations;

namespace ProjetoQualyteam.Models
{
    public class Documento
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Processo { get; set; }
        [Required]
        public string Categoria { get; set; }
        [Required]
        public byte[] Anexo { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
