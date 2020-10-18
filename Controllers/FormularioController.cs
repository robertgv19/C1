using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using C1_1.Models;
using C1_1.Data;


namespace C1_1.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        private readonly DatabaseContext _context;

        public FormularioController(ILogger<FormularioController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Formulario()
        {
            return View();
        }
          [HttpPost]
        public IActionResult Registrar(Formulario objFormulario){
            if (ModelState.IsValid)
            {

                _context.Add(objFormulario);
                _context.SaveChanges();
                objFormulario.Respuesta ="= Se registro Correctamente al curso de Alumno ";
            }
            return View("index", objFormulario);
        }

        

    }
}
