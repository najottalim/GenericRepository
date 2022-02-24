using JanobPandaEF.Data.IRepositories;
using JanobPandaEF.Domain;
using JanobPandaEF.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace JanobPandaEF.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public async Task<StudentData> GetDataOfStudent(int studentId)
        {
            return await _najotTalimDbContext.Set<StudentData>()
                .FromSqlRaw($"select * from get_data_of_student({studentId})")
                .FirstOrDefaultAsync();
        }
    }
}