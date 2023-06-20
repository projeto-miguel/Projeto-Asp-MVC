using Microsoft.AspNetCore.Mvc;

namespace SistemaDeClientes.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
    }
}
