using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class Distritos
    {
        [Key]
        public int Id { get; set; }
        public int IdProvincia { get; set; }
        public string NombreDistrito { get; set; }
    }
}
