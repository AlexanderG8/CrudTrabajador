using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTrabajador.Models
{
    public class Trabajador
    {
        [Key]
        public int Id { get; set; } 
        [Display(Name ="Tipo Documento")]
        public string TipoDocumento { get; set; } 
        [Display(Name = "Numero Documento")]
        public string NumDocumento { get; set; } 
        [Display(Name = "Nombre")]
        public string Nombres { get; set; } 
        [Display(Name = "Sexo")]
        public string Sexo { get; set; } 
        [Display(Name = "Departamento")]
        public int IdDepartamento { get; set; } 
        [Display(Name = "Provincia")]
        public int IdProvincia { get; set; } 
        [Display(Name = "Distrito")]
        public int IdDistrito { get; set; }
    }
}
