using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
    public class Faculty
    {
        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }

        public virtual List<Semester> Semesters { get; set; }
        public virtual List<User> Users { get; set; }
    }

    public class FacultyValidator : AbstractValidator<Faculty>
    {
        public FacultyValidator()
        {
            //RuleFor(x => x.Name).NotEmpty().WithMessage("không được trống").Length(10,40).WithMessage("phải trên 10 kí tự và ít hơn 40 kí tự.");
            RuleFor(x => x.Name).NotEmpty().Length(10, 40);
            RuleFor(x => x.Credits).NotEmpty();
            RuleFor(x => x.Code).Length(3,8).NotEmpty();
        }
    }
}