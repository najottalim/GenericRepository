using JanobPandaEF.Domain;
using JanobPandaEF.Domain.ViewModels;
using System.Threading.Tasks;

namespace JanobPandaEF.Data.IRepositories
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<StudentData> GetDataOfStudent(int studentId);
    }
}