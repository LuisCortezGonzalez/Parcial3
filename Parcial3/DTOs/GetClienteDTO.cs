using System.ComponentModel.DataAnnotations;

namespace Parcial3.DTOs
{
    public class GetClienteDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido.")]
        [StringLength(maximumLength: 30, ErrorMessage = "Solo pueden ser 30 caracteres.")]
        public string Nombre { get; set; }

        [Phone]
        public string Telefono { get; set; }

    }
}
