using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    public class Subject : BaseModel
    {
        [Required]
        public string Name { get; set; }
    }
}