using Microsoft.AspNetCore.Mvc;

namespace DataTableTest.Controllers
{
    public class DataController : Controller
    {
        public IActionResult GetData(Models.DataTable.DataTableParameter dtParams)
        {
            List<Models.Employee> employeeList = Models.Employee.GetMockData(200);
            List<Models.Employee> filterList = employeeList;

            return Json(new
            {
                data = filterList,
                recordsTotal = employeeList.Count,
                recordsFiltered = filterList.Count,
            });
        }
    }
}
