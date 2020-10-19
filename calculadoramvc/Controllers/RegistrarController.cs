using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using calculadoramvc.Models;
using calculadoramvc.Data;

namespace calculadoramvc.Controllers
{
    public class RegistrarController : Controller
    {
        private readonly ILogger<RegistrarController> _logger;
        private readonly DatabaseContext _context;

        public RegistrarController(ILogger<RegistrarController> logger,
            DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Registrar objRegistrar){
            if(ModelState.IsValid){
                objRegistrar.Autor="RenzoSalinas";
                _context.Add(objRegistrar);
                _context.SaveChanges();            
                objRegistrar.Respuesta="Se registro correctamente";
            }
            return View("Index",objRegistrar);
        }

        
    }
}