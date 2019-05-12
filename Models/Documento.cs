using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace aaa.Models
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
    }
}
