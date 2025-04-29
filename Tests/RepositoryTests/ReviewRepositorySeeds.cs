using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.DAL.Seeds;
using HotelManagement.Models;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class ReviewRepositorySeeds : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly ReviewRepository _reviewRepository;

        public ReviewRepositorySeeds(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _reviewRepository = new ReviewRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededReviews()
        {
            var allReviews = _reviewRepository.GetAll();

            Assert.NotEmpty(allReviews);
            Assert.Contains(allReviews, r => r.Id == Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7291"));
        }

        [Fact]
        public void GetAll_ByRoomId()
        {
            var roomId = RoomSeeds.Room1.Id;
            var reviews = _reviewRepository.GetReviewsByRoomId(roomId);

            Assert.NotEmpty(reviews);
            Assert.Contains(reviews, r => r.Id == Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7291"));
        }

        [Fact]
        public void GetAll_ByFoodId()
        {
            var foodId = FoodSeeds.Food1.Id;
            var reviews = _reviewRepository.GetReviewsByFoodId(foodId);

            Assert.NotEmpty(reviews);
            Assert.Contains(reviews, r => r.Id == Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7292"));
        }

        [Fact]
        public void GetById_ReturnsReview()
        {
            var reviewId = Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7291");
            var review = _reviewRepository.GetById(reviewId);

            Assert.NotNull(review);
            Assert.Equal(9, review.Rating);
        }

        [Fact]
        public void Create_NewReview()
        {
            var newReview = new Review
            {
                Rating = 10,
                Comment = "Excellent service!",
                RoomId = RoomSeeds.Room2.Id,
                ApplicationUserId = UserSeeds.User1.Id
            };
            var newReviewId = _reviewRepository.Create(newReview);
            var createdReview = _reviewRepository.GetById(newReviewId);

            Assert.NotNull(createdReview);
            Assert.Equal(10, createdReview.Rating);
        }

        [Fact]
        public void Update_ExistingReview()
        {
            var reviewToUpdate = _reviewRepository.GetById(Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7291"));
            Assert.NotNull(reviewToUpdate);

            reviewToUpdate.Comment = "Updated Comment";
            _reviewRepository.Update(reviewToUpdate);
            var updatedReview = _reviewRepository.GetById(reviewToUpdate.Id);

            Assert.NotNull(updatedReview);
            Assert.Equal("Updated Comment", updatedReview.Comment);
        }

        [Fact]
        public void Delete_ExistingReview()
        {
            var reviewToDelete = _reviewRepository.GetById(Guid.Parse("4aef3307-19ee-4b61-8efa-8828279e7294"));
            Assert.NotNull(reviewToDelete);

            _reviewRepository.Delete(reviewToDelete.Id);
            var deletedReview = _reviewRepository.GetById(reviewToDelete.Id);

            Assert.Null(deletedReview);
        }
    }
}
