using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //se llama para validar campo

namespace APIMATRICULAS.Models
{
    public class Curso_escolar
    {
        [Required]
        public int id { get; set; }
        [Required]
        public int ano_inicio { get; set; }
        [Required]
        public int ano_fin { get; set; }
    }
}
