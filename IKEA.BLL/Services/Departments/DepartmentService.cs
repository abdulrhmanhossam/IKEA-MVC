using IKEA.BLL.Models;
using IKEA.BLL.Services.Interfaces;
using IKEA.DAL.Entities.Departments;
using IKEA.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IKEA.BLL.Services.Departments;

public class DepartmentService : IDepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;

    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public IEnumerable<DepatmentDto> GetAllDepartments()
    {
        var departments = _departmentRepository.GetAllAsQueryable()
            .Select(department => new DepatmentDto
            {
                Id = department.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreationDate = department.CreationDate,
            }).AsNoTracking().ToList();

        return departments;
    }

    public DepatmentDetailsDto? GetADepartmentById(int id)
    {
        var department = _departmentRepository.GetById(id);
        if (department is not null)
        {
            return new DepatmentDetailsDto
            {
                Id = department!.Id,
                Name = department.Name,
                Code = department.Code,
                Description = department.Description,
                CreationDate = department.CreationDate,
                CreatedBy = department.CreatedBy,
                CreatedAt = department.CreatedAt,
                LastModificationBy = department.LastModificationBy,
                LastModificationAt = department.LastModificationAt
            };
        }
        return null;
    }

    public int UpdateDepartment(DepatmentDto depatmentDto)
    {
        var department = new Department
        {
            Code = depatmentDto.Code,
            Name = depatmentDto.Name,
            Description = depatmentDto.Description,
            CreationDate = depatmentDto.CreationDate,
            LastModificationBy = 1,
            LastModificationAt = DateTime.UtcNow
        };
        return _departmentRepository.Update(department);
    }

    public int CreateDepatment(CreatedDepatmentDto createdDepatmentDto)
    {
        var department = new Department
        {
            Code = createdDepatmentDto.Code,
            Name = createdDepatmentDto.Name,
            Description = createdDepatmentDto.Description,
            CreationDate = createdDepatmentDto.CreationDate,
            CreatedBy = 1,
            LastModificationBy = 1,
            LastModificationAt = DateTime.UtcNow
        };
        return _departmentRepository.Add(department);
    }

    public bool DeleteDepartment(int id)
    {
        var department = _departmentRepository.GetById(id);

        if (department is not null)
            return _departmentRepository.Delete(department!) > 0;

        return false;
    }
}
