using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adopet.Models
{

    [Table("Tutor")]
    public class Tutor
    {
        [Key, Required]
        public int Id { get; set; }

        [Column("nome"), Required(ErrorMessage = "Campo Obrigatório"), 
            MaxLength(80, ErrorMessage = "O nome não pode ter mais de 80 caracteres")]
        public string Nome { get; set; }

        [Column("email"), Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set;}

        [Column("senha"), Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }

        [Column("confirmarSenha")]
        public string ConfirmarSenha { get; set;}

        [Column("telefone")]
        public string Telefone { get; set; }

        [Column("mensagem"), StringLength(80)]
        public string Mensagem{ get; set; }
    }
}
