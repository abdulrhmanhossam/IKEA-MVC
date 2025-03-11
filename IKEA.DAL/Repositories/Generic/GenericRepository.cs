using IKEA.DAL.Data;
using IKEA.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace IKEA.DAL.Repositories.Generic;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IEnumerable<T> GetAll(bool noTracking = true)
    {
        if (noTracking)
            return _dbContext.Set<T>().AsNoTracking().ToList();
        return _dbContext.Set<T>().ToList();
    }
    public IQueryable<T> GetAllAsQueryable()
    {
        return _dbContext.Set<T>();
    }
    public T? GetById(int id)
    {
        return _dbContext.Set<T>().Find(id);
    }
    public int Add(T entity)
    {
        _dbContext.Set<T>().Add(entity);
        return _dbContext.SaveChanges();
    }
    public int Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
        return _dbContext.SaveChanges();
    }
    public int Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return _dbContext.SaveChanges();
    }
}
