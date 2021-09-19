using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class Departamentos
    {
        [Key]
        public int Id { get; set; }
        public string NombreDepartamento { get; set; }
    }
}
