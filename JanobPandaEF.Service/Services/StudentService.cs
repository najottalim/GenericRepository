using JanobPandaEF.Data.IRepositories;
using JanobPandaEF.Data.Repositories;
using JanobPandaEF.Domain;
using JanobPandaEF.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<Student>> GetAllAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null)
        {
            IQueryable<Student> students = await _studentRepository.GetAllAsync(predicate);

            return await students.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToListAsync();
        }

        public async Task<IEnumerable<Student>> GetAllInfoAsync(int pageSize, int pageIndex, Expression<Func<Student, bool>> predicate = null)
        {
            IQueryable<Student> students = await _studentRepository.GetAllAsync(predicate);
            return students.Include("Group.Subject").Include("University").Skip(pageSize * (pageIndex - 1)).Take(pageSize);
        }

        public async Task<Student> GetAsync(Expression<Func<Student, bool>> predicate)
        {
            var student = await _studentRepository.GetAsync(predicate);

            // something

            return student;
        }
    }
}
