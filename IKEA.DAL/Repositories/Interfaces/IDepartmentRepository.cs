using IKEA.DAL.Entities.Departments;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace IKEA.DAL.Repositories.Interfaces;

public interface IDepartmentRepository
{
    IEnumerable<Department> GetAll(bool noTracking = true);
    IQueryable<Department> GetAllAsQueryable(); // note 
    Department? GetById(int id);
    int Add(Department department);
    int Update(Department department);
    int Delete(Department department);
}
