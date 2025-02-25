using IKEA.BLL.Models;

namespace IKEA.BLL.Services.Interfaces;

public interface IDepartmentService
{
    IEnumerable<DepatmentDto> GetAllDepartments();
    DepatmentDetailsDto? GetADepartmentById(int id);
    int CreateDepatment(CreatedDepatmentDto createdDepatmentDto);
    int UpdateDepartment(DepatmentDto depatmentDto);
    bool DeleteDepartment(int id);

}
