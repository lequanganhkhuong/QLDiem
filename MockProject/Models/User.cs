using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
    public class User
    {
        [Key] public int Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public string Address { get; set; }
        public bool Gender { get; set; }

        public bool IsActive { get; set; }
        public bool? IsGraduated { get; set; }

        public int? FacultyId { get; set; }
        public int? RoleId { get; set; }
        public int? ClassesId { get; set; }
        
        
        public virtual Class Class { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Transcript> Transcripts { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }

    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Username).Length(2, 16).NotEmpty();
            RuleFor(x => x.Password).Length(2, 16).NotEmpty();
            RuleFor(x => x.Code).Length(3,10).NotEmpty();
            RuleFor(x => x.Name).Length(2,25).NotEmpty();
            RuleFor(x => x.Birthday).NotEmpty();
            RuleFor(x => x.Address).Length(2, 10).NotEmpty();
            RuleFor(x => x.RoleId).NotNull();
            RuleFor(x => x.FacultyId).NotNull();
        }
    }
}