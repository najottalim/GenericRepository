using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("groups")]
    public class Group : BaseModel
    {
        [Column("name"), MaxLength(30)]
        public string Name { get; set; }

        [Column("subject_id"), Required]
        public int SubjectId { get; set; }

        [ForeignKey(nameof(SubjectId))]
        public Subject Subject { get; set; }
    }
}