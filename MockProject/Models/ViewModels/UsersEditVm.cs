using System;
using System.ComponentModel.DataAnnotations;

namespace MockProject.Models.ViewModels
{
    public class UsersEditVm
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        public string Address { get; set; }
        public bool Gender { get; set; }

        public bool IsActive { get; set; }
        
        public int? FacultyId { get; set; }
        public int? RoleId { get; set; }
    }
}