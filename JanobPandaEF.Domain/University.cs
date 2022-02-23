using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    [Table("universities")]
    public class University : BaseModel
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("level")]
        public int Level { get; set; }
    }
}