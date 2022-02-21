using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF
{
    [Table("subjects")]
    internal class Subject
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("name"), Required]
        public string Name { get; set; }
    }
}