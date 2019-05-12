using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _1105_1.Models.Dao;
using aaa.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1105_1.Controllers
{
    public class HomeController : Controller
    {
        Documento doc1 = new Documento();

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file, Documento documento)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

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
                    Titulo = documento.Titulo,
                    Processo = documento.Processo,
                    Categoria = documento.Categoria,
                    Anexo = ms.ToArray()
                };

                DocumentoDAO dao = new DocumentoDAO();
                dao.Insert(tempDoc);

            }
            return RedirectToAction("Index");
        }
        
        /*public async Task<IActionResult> Download(string filename)
        {
            if (filename == null)
                return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", filename);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, path.GetType().ToString(), Path.GetFileName(path));
        }*/
    }
}
