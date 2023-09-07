using System.ComponentModel.DataAnnotations;
namespace ClientesBlazorServer.Models
{
    public class Cliente
    {
        //ClienteId, Nombres, Telefono, Celular, Rnc, Email, Direccion
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio.")]
        public string? Nombres { get; set; }

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El campo Teléfono debe tener el formato XXX-XXX-XXXX.")]
        public string? Telefono { get; set; }


        [Required(ErrorMessage = "El campo Celular es obligatorio.")]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "El campo Celular debe tener el formato XXX-XXX-XXXX.")]
        public string? Celular { get; set; }


        [Required(ErrorMessage = "El campo Rnc es obligatorio.")]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "El campo Rnc debe tener el formato 000000000.")]
        public int? Rnc { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no es una dirección de correo electrónico válida.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El campo Direccion es obligatorio.")]
        [StringLength(200, ErrorMessage = "El campo Dirección no debe de tener más de 200 caracteres.")]
        public string? Direccion { get; set; }
    }
}
