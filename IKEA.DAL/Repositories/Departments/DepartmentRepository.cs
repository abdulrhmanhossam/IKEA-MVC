using IKEA.DAL.Data;
using IKEA.DAL.Entities.Departments;
using IKEA.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IKEA.DAL.Repositories.Departments;

public class DepartmentRepository : IDepartmentRepository
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
    public IQueryable<Department> GetAllAsQueryable()
    {
        return _dbContext.Departments;
    }
    public Department? GetById(int id)
    {
        return _dbContext.Departments.Find(id);
    }
    public int Add(Department department)
    {
        _dbContext.Departments.Add(department);
        return _dbContext.SaveChanges();
    }
    public int Update(Department department)
    {
        _dbContext.Departments.Update(department);
        return _dbContext.SaveChanges();
    }
    public int Delete(Department department)
    {
        _dbContext.Departments.Remove(department);
        return _dbContext.SaveChanges();
    }
}
