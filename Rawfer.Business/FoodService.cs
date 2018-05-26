using Rawfer.Repository;
using Rawfer.Shared;
using System.Collections.Generic;

namespace Rawfer.Business
{
    public interface IFoodService
    {
        IEnumerable<FoodItem> GetFoodItems();
        void AddFoodItem(FoodItem foodItem);
    }

    public class FoodService : IFoodService
    {
        private IFoodItemRepository foodItemRepo;

        public FoodService(IFoodItemRepository animalRepo)
        {
            this.foodItemRepo = animalRepo;
        }

        public IEnumerable<FoodItem> GetFoodItems()
        {
            return foodItemRepo.GetFoodForUsers();
        }

        public void AddFoodItem(FoodItem foodItem)
        {
            foodItemRepo.AddFoodItem(foodItem);
        }
    }
}
