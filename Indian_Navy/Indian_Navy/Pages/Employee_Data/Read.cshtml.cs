using Indian_Navy.Data;
using Indian_Navy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Indian_Navy.Pages.Employee_Data
{
    public class ReadModel : PageModel
    {
        private readonly NavalDbContext _navalDbContext;

        public List<EmployeeData> Employee_List { get; set; }
        public ReadModel(NavalDbContext db)
        {
            this._navalDbContext = db;
        }
               
        public void OnGet()
        {
            Employee_List = _navalDbContext.EmployeeList.ToList();
        }
    }
}
