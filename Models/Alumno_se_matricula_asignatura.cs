using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //se llama para validar campos

namespace APIMATRICULAS.Models
{
    public class Alumno_se_matricula_asignatura
    {
        [Required]
        public int id_alumno { get; set; }
        [Required]
        public int id_asignatura { get; set; }
        [Required]
        public int id_curso_escolar { get; set; }
        
    }
}
