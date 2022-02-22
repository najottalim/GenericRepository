using System.Threading.Tasks;
using static System.Console;
using JanobPandaEF.Service.Services;

namespace JanobPandaEF
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var studentService = new StudentService();

            var student = await studentService.GetAsync(p => p.UniversityId == 2);

            WriteLine(student.FullName);
        }
    }
}
