using Microsoft.AspNetCore.Mvc;

namespace checkpointIV.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Fellipe Vinicius Rocha Silva";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            return Content($"Detalhes do aluno ID: {id}");
        }
    }
}