﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //se llama para validar campos

namespace APIMATRICULAS.Models
{
    public class Departamento
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String nombre { get; set; }
    }
}
