using System;
using System.ComponentModel.DataAnnotations;

namespace StudentGrades.DAL.Entities
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Grade must have an owner student")]
        public int OwnerId { get; set; }
        public Student Owner { get; set; }

        [Required(ErrorMessage = "Grade must have a value")]
        [Range(1, 5, ErrorMessage = "Grade value is out of range")]
        public int Value { get; set; }
    }
}
