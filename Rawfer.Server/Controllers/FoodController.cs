using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Rawfer.Server.Controllers
{
    using Rawfer.Shared.Models;
    using Rawfer.Shared.Services;

    [Authorize]
    [Produces("application/json")]
    [Route("api/food")]
    public class FoodController : Controller
    {
        private IFoodService foodItemService;

        public FoodController(IFoodService foodItemService)
        {
            this.foodItemService = foodItemService;
        }

        [HttpGet("")]
        public IEnumerable<FoodItem> GetFood()
        {
            return foodItemService.GetFoodItems();
        }

        [HttpPost("")]
        public void AddAnimal([FromBody] FoodItem foodItem)
        {
            foodItemService.AddFoodItem(foodItem);
        }
    }
}