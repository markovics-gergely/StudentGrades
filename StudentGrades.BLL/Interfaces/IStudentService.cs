using StudentGrades.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades.BLL.Interfaces
{
    public interface IStudentService
    {
        Task<Student> InsertStudentAsync(Student newStudent);
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<IEnumerable<StudentStatistic>> GetStudentStatisticsAsync();
        Task<Grade> AddStudentGradeAsync(Grade grade);

        Task<Student> GetStudentAsync(int studentId);
        Task<Grade> GetGradeAsync(int gradeId);
    }
}
