using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class AsignaturaContexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor
        public AsignaturaContexto(DbContextOptions<AsignaturaContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Asignatura> AsignaturaItems { get; set; }
    }
}
