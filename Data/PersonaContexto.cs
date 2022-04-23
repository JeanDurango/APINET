using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class PersonaContexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor 
        public PersonaContexto(DbContextOptions<PersonaContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Persona> PersonaItems { get; set; }
    }
}
