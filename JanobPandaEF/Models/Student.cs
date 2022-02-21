using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF
{
    [Table("students")]
    internal class Student
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("fullname"), MaxLength(50)]
        public string FullName { get; set; }

        [Column("university_id")]
        public int UniversityId { get; set; }

        [Column("group_id")]
        public int GroupId { get; set; }
    }
}