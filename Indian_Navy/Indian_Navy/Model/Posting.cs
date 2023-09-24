using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace Indian_Navy.Model
{
    public class Posting
    {
        [Display(Name = "Employee Id")]    //[Add ForeignKey]
        public virtual int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual EmployeeData employee { get; set; }

        [Display(Name = "Base")]   //[ Again Add Another ForeignKey]
        public virtual int BaseId { get; set; }

        [ForeignKey("BaseId")]
        public virtual Base bases{ get; set; }

        [Required]
        public bool Assigned { get; set; }
        [Required]
        public bool De_assigned { get; set; }
    }
}
