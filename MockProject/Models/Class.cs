using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using MockProject.Models;

public class Class
{
    [Key] public int Id { get; set; }

    public string NameClass { get; set; }

    public int Year { get; set; }

    public int FacultyId { get; set; }
        
    public virtual Faculty Faculty { get; set; }
        
    public List<User> User { get; set; }
}

public class ClassValidator : AbstractValidator<Class>
{
    public ClassValidator()
    {
        RuleFor(x => x.NameClass).NotEmpty().Length(3, 10);
        RuleFor(x => x.Year).NotEmpty();
        RuleFor(x => x.FacultyId).NotEmpty();
    }
}