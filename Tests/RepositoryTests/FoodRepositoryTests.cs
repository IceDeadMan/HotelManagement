using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using Tests.TestUtilities;

namespace Tests.RepositoryTests
{
    public class FoodRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly FoodRepository _foodRepository;
        public FoodRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _foodRepository = new FoodRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededFoods()
        {
            var allFoods = _foodRepository.GetAll();

            Assert.NotEmpty(allFoods);
            Assert.Contains(allFoods, f => f.Name == "Pizza");
        }

        [Fact]
        public void GetById_SeededFood()
        {
            var foodId = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45811");
            var foodItem = _foodRepository.GetById(foodId);

            Assert.NotNull(foodItem);
            Assert.Equal("Pizza", foodItem.Name);
        }

        [Fact]
        public void Create_NewFood()
        {
            var newFood = new Food
            {
                Name = "Sushi",
                Description = "Delicious sushi rolls",
                Price = 15.99m
            };

            var newFoodId = _foodRepository.Create(newFood);
            var createdFood = _foodRepository.GetById(newFoodId);

            Assert.NotNull(createdFood);
            Assert.Equal("Sushi", createdFood.Name);
        }

        [Fact]
        public void Update_ExistingFood()
        {
            var foodToUpdate = _foodRepository.GetById(Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45812"));
            Assert.NotNull(foodToUpdate);

            foodToUpdate.Description = "Updated Description";
            _foodRepository.Update(foodToUpdate);
            var updatedFood = _foodRepository.GetById(foodToUpdate.Id);

            Assert.NotNull(updatedFood);
            Assert.Equal("Updated Description", updatedFood.Description);
        }

        [Fact]
        public void Delete_ExistingFood()
        {
            var foodToDelete = _foodRepository.GetById(Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45813"));
            Assert.NotNull(foodToDelete);

            _foodRepository.Delete(foodToDelete.Id);
            var foodItem = _foodRepository.GetById(foodToDelete.Id);

            Assert.Null(foodItem);
        }

        [Fact]
        public void UpdateStatus_UpdatesAvailability()
        {
            var foodId = Guid.Parse("a9063d88-88c6-40db-a7e9-868afeb45811");
            _foodRepository.UpdateStatus(foodId, false);
            var updatedFood = _foodRepository.GetById(foodId);
            Assert.NotNull(updatedFood);
            Assert.False(updatedFood.IsAvailable);
        }

    }
}
