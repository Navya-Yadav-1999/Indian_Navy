using Indian_Navy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Indian_Navy.Model;

namespace Indian_Navy.Pages.Employee_Data
{ 
    [BindProperties]                //no need to add bindproperty attribute everytime

    public class CreateModel : PageModel
    {
        NavalDbContext _navalDbContext1;
        public CreateModel(NavalDbContext navalDbContext) 
        {
            _navalDbContext1 = navalDbContext;
        }
       // [BindProperty]
        public EmployeeData employeeData { get; set; }
        public void OnGet()
        {

        }
        //public async Task<IActionResult> OnPost(EmployeeData employeeData)
        public async Task<IActionResult> OnPost()           //no need to write obj here when we use BindProperty attribute
        {
            if (employeeData.EmployeeName == employeeData.NativeLocation.ToString())
            {
                ModelState.AddModelError(string.Empty, "The NativePlace cannot match the Employee Name");
            }
            if (ModelState.IsValid)
            {
                await _navalDbContext1.AddAsync(employeeData);
                await _navalDbContext1.SaveChangesAsync();
                TempData["Message"] = "Employee Details Added successfully!";
                return RedirectToPage("Employee_Data.Read");
            }
            return Page();
        }
    }
}
