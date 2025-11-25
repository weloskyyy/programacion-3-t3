using System.ComponentModel.DataAnnotations;

namespace CRUDT3.Models
{
    public class Contactomodel
    {
        public int IdContacto { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El telefono es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        public string Correo { get; set; }
    }
}
