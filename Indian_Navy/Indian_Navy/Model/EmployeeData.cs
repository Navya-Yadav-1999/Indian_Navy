using System.ComponentModel.DataAnnotations;

namespace Indian_Navy.Model
{
    public class EmployeeData
    {
        [Key]
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }


        [Display(Name = "Empoloyee Name")]
        [Required]
        [Range(1,50,ErrorMessage = "Enter Employee Name here")]
        public string EmployeeName { get; set; }


        [Display(Name = "Employee Age")]
        [Required]
        [Range(16,25,ErrorMessage = "Employee Age must be in range of 16-25")]
        public int EmployeeAge { get; set; } = 0;


        [Display(Name = "Native Location")]
        [Required(ErrorMessage ="Enter Employee Location here")]
        public string? NativeLocation { get; set; }


        [Display(Name = "Date Of Joining")]
        [Required(ErrorMessage ="Enter Correct DateOfJoining Of Employee")]

        public DateTime DateOfJoining { get; set; }
    }
}
