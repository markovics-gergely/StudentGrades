using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StudentGrades.BLL.DTOs;
using StudentGrades.BLL.Exceptions;
using StudentGrades.BLL.Interfaces;
using StudentGrades.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentGrades.BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly NorthwindContext _context;
        private readonly IMapper _mapper;
        public StudentService(NorthwindContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Grade> AddStudentGradeAsync(Grade grade)
        {
            Student student = await _mapper.ProjectTo<Student>(
                _context.Students.Where(s => s.Id == grade.OwnerId)
                ).SingleOrDefaultAsync()
                ?? throw new EntityNotFoundException("Nem található a diák");
            var efGrade = _mapper.Map<DAL.Entities.Grade>(grade);
            _context.Grades.Add(efGrade);
            await _context.SaveChangesAsync();
            return await GetGradeAsync(efGrade.Id);
        }

        public async Task<Grade> GetGradeAsync(int gradeId)
        {
            return await _mapper.ProjectTo<Grade>(
                    _context.Grades.Where(g => g.Id == gradeId)
                ).SingleOrDefaultAsync() ?? throw new EntityNotFoundException("Nem található a jegy");
        }

        public async Task<Student> GetStudentAsync(int studentId)
        {
            return await _mapper.ProjectTo<Student>(
                    _context.Students.Where(s => s.Id == studentId)
                ).SingleOrDefaultAsync() ?? throw new EntityNotFoundException("Nem található a diák");
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await
                _mapper.ProjectTo<Student>(_context.Students)
                .OrderBy(s => s.Name)
                .ToListAsync();
        }

        public async Task<IEnumerable<StudentStatistic>> GetStudentStatisticsAsync()
        {
            var studentList = await GetStudentsAsync();
            var statistics = new List<StudentStatistic>();
            foreach(Student student in studentList)
            {
                if(student.Grades.Count > 0)
                {
                    statistics.Add(
                        new StudentStatistic()
                        {
                            Id = student.Id,
                            Name = student.Name,
                            AverageMarks = Math.Round(student.Grades.Average(g => g.Value), 2),
                            BlackMarkCount = student.Grades.Where(g => g.Value == 1).Count(),
                            BestMark = student.Grades.Max(g => g.Value)
                        }
                    );
                }
            }
            return statistics.OrderByDescending(s => s.AverageMarks);
        }

        public async Task<Student> InsertStudentAsync(Student newStudent)
        {
            var efStudent = _mapper.Map<DAL.Entities.Student>(newStudent);
            _context.Students.Add(efStudent);
            await _context.SaveChangesAsync();
            return await GetStudentAsync(efStudent.Id);
        }
    }
}
