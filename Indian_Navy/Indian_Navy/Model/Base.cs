using System.ComponentModel.DataAnnotations;

namespace Indian_Navy.Model
{
    public class Base
    {
        [Key]
        [Display(Name = "Base Id")]
        public int BaseId { get; set; }

        [Display(Name = "Name Of The Base")]
        [Required(ErrorMessage ="Enter Base Location here")]
        public string NameOfTheBase { get; set; }
    }
}
