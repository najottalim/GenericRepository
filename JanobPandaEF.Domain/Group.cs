using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("groups")]
    public class Group
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("name"), MaxLength(30)]
        public string Name { get; set; }

        [Column("subject_id"), Required]
        public int SubjectId { get; set; }
    }
}