using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class spListarTrabajador
    {
        [Key]
        public int Id { get; set; }
        [Display (Name ="Documento")]
        public string Documento { get; set; }
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }
        [Display(Name = "Departamento")]
        public string NombreDepartamento { get; set; }
        [Display(Name = "Provincia")]
        public string NombreProvincia { get; set; }
        [Display(Name = "Distrito")]
        public string NombreDistrito { get; set; }
    }
}
