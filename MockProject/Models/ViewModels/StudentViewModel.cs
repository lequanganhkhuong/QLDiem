namespace MockProject.Models.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string SubjectName { get; set; }
        public double? Mark { get; set; } 
        public bool IsPass { get; set; }
    }
} 