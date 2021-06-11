using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentGrades.DAL.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Student must have a name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Student must be in a year")]
        [Range(1, 12, ErrorMessage = "Student year is out of range")]
        [Display(Name = "School Year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Student must have a birth date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Student must have a phone number")]
        [Phone]
        public string PhoneNumber { get; set; }

        public ICollection<Grade> Grades { get; set; } = new List<Grade>();
    }
}
