using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models.Entities
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Nombre Completo")]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Display(Name ="Apellidos")]
        public string LastName { get; set; }
        [MaxLength(20)]
        [Display(Name ="Telefono")]
        public string CompanyPhone { get; set; }
        [Required]
        [MaxLength(20)]
        [Display(Name ="Celular")]
        public string CellPhone { get; set; }
        [MaxLength(500)]
        [Display(Name="Dirección")]
        public string Address { get; set; } 

        //Propiedades de Lectura
        [Display(Name ="Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";

    }
}
