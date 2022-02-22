using JanobPandaEF.Data.IRepositories;
using JanobPandaEF.Data.Repositories;
using JanobPandaEF.Domain;
using JanobPandaEF.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JanobPandaEF.Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public async Task<Student> GetAsync(Expression<Func<Student, bool>> predicate)
        {
            var student = await _studentRepository.GetAsync(predicate);

            // something

            return student;
        }
    }
}
