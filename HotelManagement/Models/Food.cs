namespace HotelManagement.Models
{
    /// <summary>
    /// Represents an food item in the hotel management system.
    /// This class is used to track the name, price, and description of the food item,
    /// as well as the associated food orders and reviews for the food item.
    /// </summary>
    public class Food : BaseModel
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
