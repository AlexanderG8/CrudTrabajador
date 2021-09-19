using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class Select
    {
        [Key]
        public string value { get; set; }
        public string descripcion { get; set; }
    }
}
