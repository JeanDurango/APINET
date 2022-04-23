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
    public class PersonasController : ControllerBase
    {
        private readonly PersonaContexto _context;

        public PersonasController(PersonaContexto contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Persona>>> GetPersonaItems()
        {
            return await _context.PersonaItems.ToListAsync();
        }
    }
}
