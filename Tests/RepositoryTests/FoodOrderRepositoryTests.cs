using HotelManagement.DAL;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using HotelManagement.Enums;
using Tests.TestUtilities;
using HotelManagement.DAL.Seeds;

namespace Tests.RepositoryTests
{
    public class FoodOrderRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly HotelManagementDbContext _context;
        private readonly FoodOrderRepository _foodOrderRepository;
        private readonly FoodRepository _foodRepository;

        public FoodOrderRepositoryTests(DbContextFixture fixture)
        {
            _context = fixture.Context;
            _foodOrderRepository = new FoodOrderRepository(_context);
            _foodRepository = new FoodRepository(_context);
        }

        [Fact]
        public void GetAll_ReturnsSeededFoodOrders()
        {
            var allFoodOrders = _foodOrderRepository.GetAll();

            Assert.NotEmpty(allFoodOrders);
            Assert.Contains(allFoodOrders, fo => fo.Id == Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2961"));
        }

        [Fact]
        public void GetById_ReturnsFoodOrder()
        {
            var foodOrderId = Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2961");
            var foodOrder = _foodOrderRepository.GetById(foodOrderId);

            Assert.NotNull(foodOrder);
            Assert.Equal(OrderStatus.Pending, foodOrder.Status);
        }

        [Fact]
        public void Create_NewFoodOrder()
        {
            var foodItem = _foodRepository.GetById(FoodSeeds.Food1.Id);
            Assert.NotNull(foodItem);

            var newFoodOrder = new FoodOrder
            {
                Status = OrderStatus.Pending,
                ApplicationUserId = UserSeeds.User1.Id,
                RoomId = RoomSeeds.Room1.Id,
                Foods = new List<Food> { foodItem }
            };
            var newFoodOrderId = _foodOrderRepository.Create(newFoodOrder);
            var createdFoodOrder = _foodOrderRepository.GetById(newFoodOrderId);

            Assert.NotNull(createdFoodOrder);
            Assert.Equal(OrderStatus.Pending, createdFoodOrder.Status);
        }

        [Fact]
        public void Update_ExistingFoodOrder()
        {
            var foodOrderToUpdate = _foodOrderRepository.GetById(Guid.Parse("41d65c90-de3e-49be-8802-8cbc5b4e2961"));
            Assert.NotNull(foodOrderToUpdate);

            foodOrderToUpdate.Description = "Updated Description";
            _foodOrderRepository.Update(foodOrderToUpdate);
            var updatedFoodOrder = _foodOrderRepository.GetById(foodOrderToUpdate.Id);

            Assert.NotNull(updatedFoodOrder);
            Assert.Equal("Updated Description", updatedFoodOrder.Description);
        }
    }
}
