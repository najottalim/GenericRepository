using System.Threading.Tasks;
using static System.Console;
using JanobPandaEF.Service.Services;
using Newtonsoft.Json;

namespace JanobPandaEF
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var studentService = new StudentService();

            var students = await studentService.GetAllInfoAsync(2, 1);

            //foreach (var student in students)
            //{
            //    WriteLine(student.FullName + "\t" + student.University.Name + "\t" + student.Group.Name + "\t" + student.Group.Subject.Name);
            //}

            string json = JsonConvert.SerializeObject(students);
            System.Console.WriteLine(json);
        }
    }
}
