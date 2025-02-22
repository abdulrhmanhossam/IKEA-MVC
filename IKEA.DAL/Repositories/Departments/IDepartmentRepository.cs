using IKEA.DAL.Entities.Departments;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace IKEA.DAL.Repositories.Departments;

interface IDepartmentRepository
{
    IEnumerable<Department> GetAll(bool noTracking = true);
    Department? GetById(int id);
    int Add(Department department);
    int Update(Department department);
    int Delete(Department department);
}
