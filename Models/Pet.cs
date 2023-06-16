using System.ComponentModel.DataAnnotations.Schema;

namespace Adopet.Models
{
    [Table("Pet")]
    public class Pet
    {
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("idade")]
        public int Idade { get; set; }

        [Column("porte")]
        public string Porte { get; set; }

        [Column("comportamento")]
        public string Comportamento { get; set; }
        
    }
}
