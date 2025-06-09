namespace HotelManagement.Models.JoinEntities
{
    /// <summary>
    /// Represents a many-to-many relationship between Food and FoodOrder entities.
    /// Includes the quantity of each food item in the order.
    /// </summary>
    public class FoodOrderFood
    {
        public Guid FoodId { get; set; }
        public Food? Food { get; set; }

        public Guid FoodOrderId { get; set; }
        public FoodOrder? FoodOrder { get; set; }

        public int Quantity { get; set; }
    }
}
