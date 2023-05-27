using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSisInf.Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Autor { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Tipo { get; set;}
        public string Editorial { get; set;}
        public int AnioDefensa { get; set;}
    }
}
