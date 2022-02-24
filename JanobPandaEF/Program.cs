using System.Threading.Tasks;
using static System.Console;
using JanobPandaEF.Service.Services;
using Newtonsoft.Json;
using JanobPandaEF.Service.Interfaces;
using JanobPandaEF.Data.IRepositories;
using JanobPandaEF.Data.Repositories;

namespace JanobPandaEF
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            IStudentRepository studentService = new StudentRepository();
            var student = await studentService.GetDataOfStudent(1);

            WriteLine(student.Id + " - " + student.FullName);
        }
    }
}
