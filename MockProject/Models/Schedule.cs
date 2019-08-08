using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
    //Table Lich hoc
    public class Schedule
    {
        [Key] 
        public int Id { get; set; }
        //Teacher
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        public int SemesterId { get; set; }
        public bool IsActive { get; set; }
        
        public virtual Subject Subject { get; set; }
        public virtual User User { get; set; }
        public virtual Semester Semester { get; set; }
        
        public virtual ICollection<Transcript> Transcripts { get; set; }
    }

    public class ScheduleValidator : AbstractValidator<Schedule>
    {
        public ScheduleValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.SubjectId).NotEmpty();
            RuleFor(x => x.SemesterId).NotEmpty();
            
        }
    }
}