namespace HotelManagement.Models
{
    public class Food
    {
        public Guid Id { get; init; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }

        public ICollection<FoodOrder> FoodOrders { get; set; } = new List<FoodOrder>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
