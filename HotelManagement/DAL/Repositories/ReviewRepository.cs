using HotelManagement.Models;

namespace HotelManagement.DAL.Repositories
{
    /// <summary>
    /// Repository for managing reviews in the hotel management system.
    /// Additional methods for retrieving reviews by room and food IDs, as well as by user ID.
    /// </summary>
    public class ReviewRepository : BaseRepository<Review>
    {
        public ReviewRepository(HotelManagementDbContext context) : base(context)
        {
        }

        public IList<Review> GetReviewsByRoomId(Guid hotelId)
        {
            return _context.Reviews
                .Where(r => r.RoomId == hotelId)
                .ToList();
        }

        public IList<Review> GetReviewsByFoodId(Guid foodId)
        {
            return _context.Reviews
                .Where(r => r.FoodId == foodId)
                .ToList();
        }

        
        public Review? GetByFoodIdAndUserId(Guid foodId, Guid userId)
        {
            return _context.Reviews
                .SingleOrDefault(r => r.FoodId == foodId && r.ApplicationUserId == userId);
        }
    }
}
