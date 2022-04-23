using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class Curso_escolarContexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor 
        public Curso_escolarContexto(DbContextOptions<Curso_escolarContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Curso_escolar> Curso_escolarItems { get; set; }
    }
}
