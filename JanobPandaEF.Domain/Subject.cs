using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("subjects")]
    public class Subject
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("name"), Required]
        public string Name { get; set; }
    }
}