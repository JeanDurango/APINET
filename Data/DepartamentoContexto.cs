using APIMATRICULAS.Models; //se llama para usar la propiedad que hace referencia al modelo
using Microsoft.EntityFrameworkCore; //se llama o se instalda desde herramientas paqietes nuget
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMATRICULAS.Data
{
    public class DepartamentoContexto : DbContext
    {
        //este es un constructo que me hara el mapeo de la tabla profesor 
        public DepartamentoContexto(DbContextOptions<DepartamentoContexto> options) : base(options)
        {

        }
        //esto es una propiedad
        public DbSet<Departamento> DepartamentoItems { get; set; }
    }
}
