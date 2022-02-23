using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("subjects")]
    public class Subject : BaseModel
    {
        [Column("name"), Required]
        public string Name { get; set; }
    }
}