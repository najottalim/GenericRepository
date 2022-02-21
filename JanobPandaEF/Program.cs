using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Console;

namespace JanobPandaEF
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IStudentRepository studentRepository = new StudentRepository();

            var student = await studentRepository.UpdateAsync(new Student
            {
                Id = 1,
                FullName = "Niyozbek Mirzayev2",
                GroupId = 1,
                UniversityId = 2
            });

            WriteLine(student.FullName);

        }
    }
}
