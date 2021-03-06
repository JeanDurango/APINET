using APIMATRICULAS.Data;
using APIMATRICULAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace APIMATRICULAS.Controllers
{
    public class GradosController : ControllerBase
    {
        private readonly GradoContexto _context;

        public GradosController(GradoContexto contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grado>>> GetGradoItems()
        {
            return await _context.GradoItems.ToListAsync();
        }
    }
}
