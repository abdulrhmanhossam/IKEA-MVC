using IKEA.DAL.Common.Enums;

namespace IKEA.DAL.Entities.Employees;

public class Employee : BaseEntity
{
    public string Name { get; set; } = null!;
    public int? Age { get; set; } = null!;
    public string? Address { get; set; }
    public decimal Salary { get; set; }
    public bool IsActive { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime HiringDate { get; set; }
    public Gender Gender { get; set; }
    public EmployeeType EmployeeType { get; set; }
}
