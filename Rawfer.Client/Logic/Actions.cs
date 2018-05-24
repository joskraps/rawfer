using BlazorRedux;
using Rawfer.Shared;
using System.Collections.Generic;

namespace Rawfer.Client.Logic
{
    public class AddAnimalAction : IAction { }
    public class LoadAnimalsAction : IAction { }
    public class ClearAnimalsAction : IAction { }
    public class EditAnimal : IAction
    {
        public Animal Animal { get; set; }
    }

    public class CancelAddAction : IAction { }
    public class ReceiveAnimalsAction : IAction
    {
        public IEnumerable<Animal> Animals { get; set; }
    }

    public class LoginAction : IAction { }
    public class ClearUserAction : IAction { }
    public class CreateUserAction : IAction { }
    public class UserCreatedAction : IAction {}
    public class EditUserAction : IAction { }
    public class GetUserAction: IAction {}
    public class UserLoggedInAction : IAction
    {
        public UserModel createdUser { get; set; }

        public UserLoggedInAction(UserModel createdUser)
        {
            this.createdUser = createdUser;
        }
    }
    public class ReceiveProvidersAction : IAction
    {
        public IEnumerable<SigninProviderViewModel> Providers { get; set; }
    }
}
