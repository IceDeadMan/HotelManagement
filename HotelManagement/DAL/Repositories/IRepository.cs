using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    public interface IRepository<TModel> where TModel : IModel
    {
        IList<TModel> GetAll();
        Task<IList<TModel>> GetAllAsync();
        TModel? GetById(Guid id);
        Guid Create(TModel model);
        Guid? Update(TModel model);
        void Delete(Guid id);
        bool Exists(Guid id);
    }
}
