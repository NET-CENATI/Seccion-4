using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seccion_4.Models;

namespace Seccion_4.Controllers
{
    public class EspecialidadControllers : Controller
    {
        private readonly TurnosContext _context;
        public EspecialidadControllers(TurnosContext contex) 
        {
            _context = contex;

        }

        public IActionResult Index()
        {
            return View(_context.Especialidad.ToList());
        }
    }
}