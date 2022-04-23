using APIMATRICULAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class Alumno_se_matricula_asignaturaConexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor
        public Alumno_se_matricula_asignaturaConexto(DbContextOptions<Alumno_se_matricula_asignaturaConexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Alumno_se_matricula_asignatura> Alumno_se_matricula_asignaturaItems { get; set; }

    }
}
