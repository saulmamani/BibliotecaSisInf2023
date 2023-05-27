using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSisInf.Models
{
    public class Estudiante
    {
        [Key]
        public string Matrila { get; set; }
        [Required]
        public string Ci { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        public string Carrera { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
