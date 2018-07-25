namespace Rawfer.Client.Logic
{
    using System;
    using System.Collections.Generic;

    using BlazorRedux;

    using Rawfer.Shared.Models;

    public class Reducers
    {
        private static IEnumerable<Animal> AnimalReducer(IEnumerable<Animal> animals, IAction action)
        {
            switch (action)
            {
                case ClearAnimalsAction _:
                    return null;
                case ReceiveAnimalsAction a:
                    return a.Animals;
                default:
                    return animals;
            }
        }

        private static IEnumerable<FoodItem> FoodItemReducer(IEnumerable<FoodItem> foodItems, IAction action)
        {
            switch (action)
            {
                case ClearAnimalsAction _:
                    return null;
                case ReceiveFoodsAction a:
                    return a.FoodItems;
                default:
                    return foodItems;
            }
        }

        private static IEnumerable<SigninProviderViewModel> ProviderReducer(
            IEnumerable<SigninProviderViewModel> providers,
            IAction action)
        {
            switch (action)
            {
                case ClearUserAction _:
                    return null;
                case ReceiveProvidersAction r:
                    return r.Providers;
                default:
                    return providers;
            }
        }

        public static RawferState RootReducer(RawferState state, IAction action)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            return new RawferState
                       {
                           Animals = AnimalReducer(state.Animals, action),
                           User = UserReducer(state.User, action),
                           Providers = ProviderReducer(state.Providers, action),
                           FoodItems = FoodItemReducer(state.FoodItems, action)
                       };
        }

        private static UserModel UserReducer(UserModel user, IAction action)
        {
            switch (action)
            {
                case ClearUserAction _:
                    return null;
                case UserLoggedInAction l:
                    return l.CreatedUser;
                default:
                    return user;
            }
        }
    }
}