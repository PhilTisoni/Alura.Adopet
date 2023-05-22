using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adopet.Models
{

    [Table("Visitante")]
    public class Visitante
    {
        [Key]
        private Guid Id { get; set; }

        [Column("nome")]
        [StringLength(80)]
        private string Nome { get; set; }

        [Column("email")]
        private string Email { get; set;}

        [Column("senha")]
        private string Senha { get; set; }

        [Column("confirmarSenha")]
        private string ConfirmarSenha { get; set;}

        [Column("telefone")]
        private string Telefone { get; set; }

        [Column("mensagem")]
        [StringLength(80)]
        private string Mensagem{ get; set; }
    }
}
