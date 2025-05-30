namespace HotelManagement.Models.JoinEntities
{
    public class FoodOrderFood
    {
        public Guid FoodId { get; set; }
        public Food? Food { get; set; }

        public Guid FoodOrderId { get; set; }
        public FoodOrder? FoodOrder { get; set; }

        public int Quantity { get; set; }
    }
}
