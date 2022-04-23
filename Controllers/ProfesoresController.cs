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
    public class ProfesoresController : ControllerBase
    {
        private readonly ProfesorContexto _context;

        public ProfesoresController(ProfesorContexto contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public async Task <ActionResult <IEnumerable<Profesor>>> GetProfesorItems ()
        {
            return await _context.ProfesorItems.ToListAsync();
        }
    }
}
