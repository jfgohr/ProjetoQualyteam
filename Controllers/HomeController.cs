using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ProjetoQualyteam.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames.Application;
using ProjetoQualyteam.Models.Dao;

namespace ProjetoQualyteam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Documento = new Documento();
            return View();
        }


        public IActionResult Lista()
        {
            DocumentoDAO dao = new DocumentoDAO();
            ViewBag.Documentos = dao.SelectAll().OrderBy(t => t.Titulo);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adiciona(IFormFile file, Documento documento)
        {
            DocumentoDAO dao = new DocumentoDAO();

            if (file == null || file.Length == 0)
                return Content("file not selected");

            Documento temp = dao.DocumentoById(documento.Id);
            if (temp != null)
            {
                ViewBag.Documento = temp;
                return View("Index");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            if (file != null)
            {
                MemoryStream ms = new MemoryStream();
                file.OpenReadStream().CopyTo(ms);

                Documento tempDoc = new Documento
                {
                    Id = documento.Id,
                    Titulo = documento.Titulo,
                    Processo = documento.Processo,
                    Categoria = documento.Categoria,
                    Anexo = ms.ToArray(),
                    Nome = file.FileName
                };

                dao.Insert(tempDoc);
            }
            ViewBag.Sucesso = true;
            return View("Index");
        }

        public FileResult Download(int id)
        {
            DocumentoDAO dao = new DocumentoDAO();
            var documento = dao.DocumentoById(id);

            return File(documento.Anexo, Octet, documento.Nome);
        }
    }
}
