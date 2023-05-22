using System.ComponentModel.DataAnnotations.Schema;

namespace Adopet.Models
{
    [Table("Pet")]
    public class Pet
    {
        [Column("nome")]
        private string Nome { get; set; }

        [Column("idade")]
        private int Idade { get; set; }

        [Column("porte")]
        private string Porte { get; set; }

        [Column("comportamento")]
        private string Comportamento { get; set; }
        
    }
}
