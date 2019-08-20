using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace MockProject.Models
{
    //table diem
    public class Transcript
    {
        [Key] public int Id { get; set; }

        public int? ScheduleId { get; set; }

        //Student
        public int? UserId { get; set; }
        public double? Mark { get; set; }
        public bool IsPassed { get; set; }
        public bool IsActive { get; set; }


        public virtual Schedule Schedule { get; set; }
        public virtual User User { get; set; }
        
    }

    public class TranscriptValidator : AbstractValidator<Transcript>
    {
        public TranscriptValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.Mark).NotEmpty();
            
        }
    }
}