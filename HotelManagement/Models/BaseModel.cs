namespace HotelManagement.Models
{
    /// <summary>
    /// Base class for all models in the application.
    /// </summary>
    public abstract class BaseModel : IModel
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        protected BaseModel()
        {
        }

        protected BaseModel(Guid id)
        {
            Id = id;
        }
    }
}
