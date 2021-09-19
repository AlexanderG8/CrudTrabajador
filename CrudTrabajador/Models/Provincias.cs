using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class Provincias
    {
        [Key]
        public int Id { get; set; }
        public int IdDepartamento { get; set; }
        public string NombreProvincia { get; set; }
    }
}
