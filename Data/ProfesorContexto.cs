using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class ProfesorContexto : DbContext
    {
        internal object Alumno_se_matricula_asignaturaItems;

        //este es un constructo que me hara el mapeo de la tabla profesor 
        public ProfesorContexto(DbContextOptions<ProfesorContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Profesor> ProfesorItems { get; set; }
    }

}
