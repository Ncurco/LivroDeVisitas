using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using livro_de_visita.Models;
using Microsoft.AspNetCore.Mvc;

namespace livro_de_visita.Controllers
{
    public class VisitasController : Controller
    {
        FacadeVisitas Facade = new FacadeVisitas();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Visita v)
        {
            Facade.Salvar(v);
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            ViewBag.MyList = Facade.ListarTodas();
            return View();
        }
    }
}