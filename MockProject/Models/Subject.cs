using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
    //table mon hoc
    public class Subject
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool IsActive { get; set; }
        
        
        public virtual ICollection<Schedule> Schedules { get; set; }
    }

    public class SubjectValidator : AbstractValidator<Subject>
    {
       public SubjectValidator()
       {
           RuleFor(x => x.Name).Length(2, 30).NotEmpty();
           RuleFor(x => x.Credits).NotEmpty();
       }
    }
}