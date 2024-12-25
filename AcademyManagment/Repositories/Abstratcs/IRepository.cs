using AcademyManagment.Entities;

namespace AcademyManagment.Repositories.Abstratcs;

public interface IRepository<T> where T : BaseEntity, new()
{
    public IQueryable<T> GetAll(bool isTracking, params string[] includes);
}
