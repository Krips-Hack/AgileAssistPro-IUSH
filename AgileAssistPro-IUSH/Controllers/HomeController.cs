﻿using AgileAssistPro_IUSH.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AgileAssistPro_IUSH.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Aquí creamos un parámetro logger de la interfaz Ilogger del paquete de entity.

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//HOME ES EL INDEX NORMAL PARA TODOS, QUE DICE BIENVENIDO. dEBO CAMBIAR ES EL LAYOUT POR ROL