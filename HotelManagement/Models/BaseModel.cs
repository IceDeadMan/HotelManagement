namespace HotelManagement.Models
{
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
