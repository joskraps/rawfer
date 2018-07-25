namespace Rawfer.Shared.Services
{
    using System.Collections.Generic;

    using Rawfer.Shared.Models;
    using Rawfer.Shared.Repositories;

    public class FoodService : IFoodService
    {
        private IFoodItemRepository foodItemRepo;

        public FoodService(IFoodItemRepository animalRepo)
        {
            this.foodItemRepo = animalRepo;
        }

        public void AddFoodItem(FoodItem foodItem)
        {
            this.foodItemRepo.AddFoodItem(foodItem);
        }

        public IEnumerable<FoodItem> GetFoodItems()
        {
            return this.foodItemRepo.GetFoodForUsers();
        }
    }
}