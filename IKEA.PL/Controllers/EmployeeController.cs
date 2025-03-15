using IKEA.BLL.Services.Employees;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.PL.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;
    private readonly IWebHostEnvironment _environment;
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController
        (IEmployeeService employeeService,
        IWebHostEnvironment environment, ILogger<EmployeeController> logger)
    {
        _employeeService = employeeService;
        _environment = environment;
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var employees = _employeeService.GetAllEmployees();

        return View(employees);
    }
}
