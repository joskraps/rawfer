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
                Animals  = AnimalReducer(state.Animals,action)
            };
        }


        private static IEnumerable<Animal> AnimalReducer(IEnumerable<Animal> animals, IAction action)
        {
            switch (action)
            {
                case ClearAnimalsAction _:
                    return null;
                case ReceiverAnimalsAction a:
                    return a.Animals;
                default:
                    return animals;
            }
        }
    }
}
