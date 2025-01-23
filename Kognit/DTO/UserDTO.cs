using System.ComponentModel.DataAnnotations;

namespace Kognit.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome pode ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter 11 dígitos.")] // formato para validar o CPF
        public string CPF { get; set; }
    }
}
