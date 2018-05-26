using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Rawfer.Business;
using Rawfer.Shared;

namespace Rawfer.Server.Controllers
{
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
            return new List<FoodItem>
            {
                new FoodItem
                {
                    Id = 1,
                    Name = "Beef Supreme Mix",
                    Type = FoodType.Meat,
                    ProteinPercent = "80.00",
                    FatPercent = "10.00",
                    FiberPercent = "15.00",
                    MoisturePercent = "75.00"
                },                new FoodItem
                {
                    Id = 2,
                    Name = "Beaver Mix",
                    Type = FoodType.Meat,
                    ProteinPercent = "80.00",
                    FatPercent = "10.00",
                    FiberPercent = "15.00",
                    MoisturePercent = "75.00"
                }
            };
            //return foodItemService.GetFoodItems();
        }

        [HttpPost("")]
        public void AddAnimal([FromBody] FoodItem foodItem)
        {
            foodItemService.AddFoodItem(foodItem);
        }
    }
}