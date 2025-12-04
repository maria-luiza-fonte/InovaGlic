using InovaGlic.Models;
using Microsoft.AspNetCore.Mvc;

namespace InovaGlic.Controllers
{
    public class HomeController : Controller
    {
        // Método que carrega a página inicial
        public IActionResult Index()
        {
            return View();
        }

        // Método para receber mensagem de contato
        [HttpPost]
        public IActionResult EnviarMensagem(string nome, string email, string mensagem)
        {
            // Aqui você poderia salvar no banco de dados
            // Por enquanto, só mostra uma mensagem de sucesso

            TempData["Sucesso"] = "Mensagem enviada com sucesso!";
            return RedirectToAction("Index");
        }
    }
}