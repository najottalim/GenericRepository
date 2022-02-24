using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanobPandaEF.Domain.ViewModels
{
    public class StudentData
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string UniversityName { get; set; }

        public string GroupName { get; set; }

        public string SubjectName { get; set; }
    }
}
