using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class GradoContexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor 
        public GradoContexto(DbContextOptions<GradoContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Grado> GradoItems { get; set; }
    }
}
