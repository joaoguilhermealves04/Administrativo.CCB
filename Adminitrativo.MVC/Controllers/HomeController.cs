using Adiministativo.CCB.Aplication.IServices;
using Adiministativo.CCB.Aplication.Model;
using Administrativo.CCB.Dominio.Entity;
using Adminitrativo.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Adminitrativo.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioServices _usuarioServices;

        public HomeController(IUsuarioServices usuarioServices)
        {
            _usuarioServices = usuarioServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var Usuariodba = await _usuarioServices.AuthenticateUserAsync(loginModel);

                if (Usuariodba == null)
                {
                    return View(loginModel);
                }

                return View("");
            }
            else
            {
                return View(loginModel);
            }
        }
    }
}
