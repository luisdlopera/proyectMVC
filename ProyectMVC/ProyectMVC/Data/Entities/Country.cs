using System.ComponentModel.DataAnnotations;

namespace ProyectMVC.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="pais")]
        [MaxLength(255, ErrorMessage = " ingresa los caracteres necesarios")]
        [Required (ErrorMessage ="Ingrese el campo requerido")]
        public int Name { get; set; }

    }
}
