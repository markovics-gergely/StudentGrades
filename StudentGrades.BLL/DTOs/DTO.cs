using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentGrades.BLL.DTOs
{
    public record Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.", AllowEmptyStrings = false)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1, 12, ErrorMessage = "Student year is not valid")]
        [Display(Name = "School Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Birth date is required.")]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date, ErrorMessage = "Birth Date is not valid")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Display(Name = "Phone number")]
        [Phone(ErrorMessage = "Phone number is not valid")]
        public string PhoneNumber { get; set; }

        public List<Grade> Grades { get; set; }
    }

    public record StudentStatistic
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "AverageMarks is required.")]
        [Display(Name = "Average of the marks")]
        public double AverageMarks { get; set; }

        [Required(ErrorMessage = "BlackMarkCount is required.")]
        [Display(Name = "Count of black marks")]
        public int BlackMarkCount { get; set; }

        [Required(ErrorMessage = "BestMark is required.")]
        [Display(Name = "Best got mark")]
        public int BestMark { get; set; }
    }

    public record Grade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Grade Owner is required.")]
        [Display(Name = "Id of the student")]
        public int OwnerId { get; set; }
        public Student Owner { get; set; }

        [Required(ErrorMessage = "Grade Value is required.")]
        [Range(1, 5, ErrorMessage = "Grade is not valid")]
        [Display(Name = "Grade value")]
        public int Value { get; set; }
    }
}
