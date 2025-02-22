namespace IKEA.DAL.Entities.Departments;

public class Department : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string? Description { get; set; }
    public DateOnly CreationDate { get; set; }
}
