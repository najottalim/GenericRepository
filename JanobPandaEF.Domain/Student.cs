using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("students")]
    public class Student : BaseModel
    {
        [Column("fullname"), MaxLength(50)]
        public string FullName { get; set; }

        [Column("university_id")]
        public int UniversityId { get; set; }

        [ForeignKey(nameof(UniversityId))]
        public University University { get; set; }

        [Column("group_id")]
        public int GroupId { get; set; }

        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}