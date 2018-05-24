using BlazorRedux;
using Rawfer.Shared;
using System;
using System.Collections.Generic;

namespace Rawfer.Client.Logic
{
    public class Reducers
    {
        public static RawferState RootReducer(RawferState state, IAction action)
        {
            if (state == null)
                throw new ArgumentNullException(nameof(state));

            return new RawferState()
            {
                Animals = AnimalReducer(state.Animals, action),
                User = UserReducer(state.User, action),
                Providers =ProviderReducer(state.Providers, action)
            };
        }


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
        private static UserModel UserReducer(UserModel user, IAction action)
        {
            switch (action)
            {
                case ClearUserAction _:
                    return null;
                case UserLoggedInAction l:
                    return l.createdUser;
                default:
                    return user;
            }
        }
        private static IEnumerable<SigninProviderViewModel> ProviderReducer(IEnumerable<SigninProviderViewModel> providers, IAction action)
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
    }
}
