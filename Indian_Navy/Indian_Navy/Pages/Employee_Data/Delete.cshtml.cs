using Indian_Navy.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Indian_Navy.Model;

namespace Indian_Navy.Pages.Employee_Data
{ 
    [BindProperties]                //no need to add bindproperty attribute everytime

    public class DeleteModel : PageModel
    {
        NavalDbContext _navalDbContext1;
        public DeleteModel(NavalDbContext navalDbContext) 
        {
            _navalDbContext1 = navalDbContext;
        }
       // [BindProperty]
        public EmployeeData employeeData { get; set; }
        public void OnGet(int id)
        {
            employeeData = _navalDbContext1.EmployeeList.Find(id);
            //employeeData = _navalDbContext1.EmployeeList.First(u=>u.EmployeeId==id);          different ways of doing same thing 
            //employeeData = _navalDbContext1.EmployeeList.FirstOrDefault(u => u.EmployeeId == id);
            //employeeData = _navalDbContext1.EmployeeList.Where(u => u.EmployeeId == id).FirstOrDefault();
        }
        //public async Task<IActionResult> OnPost(EmployeeData employeeData)
        public async Task<IActionResult> OnPost()           //no need to write obj here when we use BindProperty attribute
        {
                var EmployeeFromDb = _navalDbContext1.EmployeeList.Find(employeeData.EmployeeId);
                if (EmployeeFromDb != null)
                {
                    _navalDbContext1.EmployeeList.Remove(EmployeeFromDb);
                    await _navalDbContext1.SaveChangesAsync();
                    TempData["Message"] = "Employee Data Deleted successfully!";
                    return RedirectToPage("Employee_Data.Read");
                }
                return Page();
        }
    }
}
