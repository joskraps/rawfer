namespace Rawfer.Shared.Services
{
    using System.Collections.Generic;

    using Rawfer.Shared.Models;

    public interface IFoodService
    {
        void AddFoodItem(FoodItem foodItem);

        IEnumerable<FoodItem> GetFoodItems();
    }
}