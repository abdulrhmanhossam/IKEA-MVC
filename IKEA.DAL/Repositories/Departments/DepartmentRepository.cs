using IKEA.DAL.Data;
using IKEA.DAL.Entities.Departments;
using Microsoft.EntityFrameworkCore;

namespace IKEA.DAL.Repositories.Departments;

class DepartmentRepository : IDepartmentRepository
{
    private readonly AppDbContext _dbContext;

    public DepartmentRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<Department> GetAll(bool noTracking = true)
    {
        if (noTracking)
            return _dbContext.Departments.AsNoTracking().ToList();
        return _dbContext.Departments.ToList();
    }

    public Department? GetById(int id)
    {
        return _dbContext.Departments.Find(id);
    }
    public int Add(Department department)
    {
        throw new NotImplementedException();
    }
    public int Update(Department department)
    {
        throw new NotImplementedException();
    }

    public int Delete(Department department)
    {
        throw new NotImplementedException();
    }
}
