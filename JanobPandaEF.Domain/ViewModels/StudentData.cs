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
        [Column("id")]
        public int Id { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }

        [Column("university_name")]

        public string UniversityName { get; set; }

        [Column("group_name")]
        public string GroupName { get; set; }

        [Column("subject_name")]
        public string SubjectName { get; set; }
    }
}
