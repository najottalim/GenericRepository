using System.ComponentModel.DataAnnotations.Schema;

namespace JanobPandaEF.Domain
{
    public class University : BaseModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Level { get; set; }
    }
}