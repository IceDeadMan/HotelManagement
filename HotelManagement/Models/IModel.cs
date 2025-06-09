namespace HotelManagement.Models
{
    /// <summary>
    /// Represents a base model interface that includes an identifier.
    /// Used to ensure that all models have a unique identifier,
    /// and later to delegate in repository methods.
    /// </summary>
    public interface IModel
    {
        public Guid Id { get; init; }
    }
}
