using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    public class Student : BaseModel
    {
        [MaxLength(50)]
        public string FullName { get; set; }

        public int UniversityId { get; set; }

        [ForeignKey(nameof(UniversityId))]
        public University University { get; set; }

        public int GroupId { get; set; }

        [ForeignKey(nameof(GroupId))]
        public Group Group { get; set; }
    }
}