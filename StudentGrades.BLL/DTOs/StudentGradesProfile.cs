using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades.BLL.DTOs
{
    public class StudentGradesProfile : Profile
    {
        public StudentGradesProfile()
        {
            CreateMap<DAL.Entities.Student, Student>().ReverseMap();
            CreateMap<DAL.Entities.Grade, Grade>().ReverseMap();
        }
    }
}
