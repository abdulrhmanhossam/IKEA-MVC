namespace IKEA.BLL.Models;

public class DepatmentDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    public string? Description { get; set; }
    public DateOnly CreationDate { get; set; }
}
