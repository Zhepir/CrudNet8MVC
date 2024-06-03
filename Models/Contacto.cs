using System.ComponentModel.DataAnnotations;

namespace CrudNet8MVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage ="El nombre es obligatorio")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "El Celular es obligatorio")]
        public String Celular { get; set; }

        [Required(ErrorMessage = "El Email es obligatorio")]
        public String Email { get; set; }
        
        public DateTime Fechacreacion { get; set; }

    }
}
