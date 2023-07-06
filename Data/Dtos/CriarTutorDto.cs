using System.ComponentModel.DataAnnotations;

namespace Adopet.Data.Dtos
{
    public class CriarTutorDto
    {
        [Required(ErrorMessage = "Campo Obrigatório"),
        StringLength(80, ErrorMessage = "O nome não pode ter mais de 80 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }     
    }
}
