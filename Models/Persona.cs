using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //se llama para validar campos

namespace APIMATRICULAS.Models
{
    public class Persona
    {
        [Required]
        public int id { get; set; }
        [Required]
        public String nif { get; set; }
        [Required]
        public String nombre { get; set; }
        [Required]
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        [Required] 
        public String ciudad { get; set; }
        [Required] 
        public String direccion { get; set; }
        public String telefono { get; set; }
        [Required] 
        public DateTime fecha_nacimiento { get; set; }
        [Required] 
        public String sexo { get; set; }
        [Required] 
        public String tipo { get; set; } 
        public String Clave { get; set; }
    }
}
