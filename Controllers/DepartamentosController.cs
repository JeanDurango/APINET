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
    public class DepartamentosController : ControllerBase
    {
        private readonly DepartamentoContexto _context;

        public DepartamentosController(DepartamentoContexto contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departamento>>> GetDepartamentoItems()
        {
            return await _context.DepartamentoItems.ToListAsync();
        }
    }
}
