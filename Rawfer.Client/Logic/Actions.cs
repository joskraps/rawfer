namespace Rawfer.Client.Logic
{
    using System.Collections.Generic;

    using BlazorRedux;

    using Rawfer.Shared.Models;

    public class AddAnimalAction : IAction
    {
    }

    public class LoadAnimalsAction : IAction
    {
    }

    public class ClearAnimalsAction : IAction
    {
    }

    public class EditAnimal : IAction
    {
        public Animal Animal { get; set; }
    }

    public class CancelAnimalAdd : IAction
    {
    }

    public class ReceiveAnimalsAction : IAction
    {
        public IEnumerable<Animal> Animals { get; set; }
    }

    public class LoginAction : IAction
    {
    }

    public class ClearUserAction : IAction
    {
    }

    public class CreateUserAction : IAction
    {
    }

    public class UserCreatedAction : IAction
    {
    }

    public class EditUserAction : IAction
    {
    }

    public class GetUserAction : IAction
    {
    }

    public class UserLoggedInAction : IAction
    {
        public UserModel CreatedUser { get; set; }

        public UserLoggedInAction(UserModel createdUser)
        {
            this.CreatedUser = createdUser;
        }
    }

    public class ReceiveProvidersAction : IAction
    {
        public IEnumerable<SigninProviderViewModel> Providers { get; set; }
    }

    public class AddFoodAction : IAction
    {
    }

    public class LoadFoodsAction : IAction
    {
    }

    public class ClearFoodsAction : IAction
    {
    }

    public class EditFood : IAction
    {
        public FoodItem Food { get; set; }
    }

    public class CancelFoodAdd : IAction
    {
    }

    public class ReceiveFoodsAction : IAction
    {
        public IEnumerable<FoodItem> FoodItems { get; set; }
    }
}