using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
   //table nam hoc, hoc ki
    public class Semester
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyId { get; set; }
        public int Year { get; set; }
        public bool IsActive { get; set; }
        
        
        public virtual List<Schedule> Schedules { get; set; }
        public virtual Faculty Faculty { get; set; }
    }

    public class SemesterValidator : AbstractValidator<Semester>
    {
        public SemesterValidator()
        {
            RuleFor(x => x.Name).Length(3, 10).NotEmpty();
            RuleFor(x => x.FacultyId).NotEmpty();
            RuleFor(x => x.Year).NotEmpty();
        }
    }
}