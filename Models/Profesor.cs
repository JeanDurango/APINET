using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //se llama para validar campos

namespace APIMATRICULAS.Models
{
    public class Profesor
    {
        [Required]// se debe llamar la libreria
        public int id_profesor { get; set; }
        [Required]
        public int id_departamento { get; set; }
    }
}
