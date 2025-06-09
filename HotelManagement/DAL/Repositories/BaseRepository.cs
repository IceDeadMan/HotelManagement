using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// BaseRepository provides a generic implementation for CRUD operations on entities.
    /// It implements the IRepository interface and uses Entity Framework Core for database operations.
    /// </summary>
    public class BaseRepository<TModel> : IRepository<TModel>, IDisposable where TModel : class, IModel
    {
        protected readonly HotelManagementDbContext _context;

        public BaseRepository(HotelManagementDbContext context)
        {
            _context = context;
        }

        public Guid Create(TModel model)
        {
            var newEntity = _context.Set<TModel>().Add(model);
            _context.SaveChanges();

            return newEntity.Entity.Id;
        }

        public void Delete(Guid id)
        {
            var model = _context.Set<TModel>().SingleOrDefault(e => e.Id == id);
            if (model != null)
            {
                _context.Set<TModel>().Remove(model);
                _context.SaveChanges();
            }
        }

        public bool Exists(Guid id)
        {
            return _context.Set<TModel>().Any(e => e.Id == id);
        }

        public virtual IList<TModel> GetAll()
        {
            return _context.Set<TModel>().ToList();
        }

        public virtual async Task<IList<TModel>> GetAllAsync()
        {
            return await _context.Set<TModel>().ToListAsync();
        }

        public TModel? GetById(Guid id)
        {
            return _context.Set<TModel>().SingleOrDefault(e => e.Id == id);
        }

        public Guid? Update(TModel model)
        {
            if (Exists(model.Id))
            {
                _context.Set<TModel>().Attach(model);
                var updatedEntity = _context.Set<TModel>().Update(model);
                _context.SaveChanges();

                return updatedEntity.Entity.Id;
            }
            else
            {
                return null;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
