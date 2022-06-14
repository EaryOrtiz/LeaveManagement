using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Deafult number o days")]
        [Required]
        public string Name { get; set; }
        
        [Display(Name = "Deafult number o days")]
        [Required]
        [Range(1, 25, ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }
    }
}
