using AcademyManagment.Context;
using AcademyManagment.Entities;
using AcademyManagment.Repositories.Abstratcs;
using Microsoft.EntityFrameworkCore;

namespace AcademyManagment.Repositories.Implements;

public class Repository<T>(AppDbContext _context) : IRepository<T> where T : BaseEntity, new()
{
    public IQueryable<T> GetAll(bool isTracking, params string[] includes)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!isTracking)
            query = query.AsNoTracking();

        if (includes.Length > 0)
            foreach (string include in includes)
                query = query.Include(include);

        return query;
    }
}
