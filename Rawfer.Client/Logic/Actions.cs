using BlazorRedux;
using Rawfer.Shared;
using System.Collections.Generic;

namespace Rawfer.Client.Logic
{
    public class AddAnimalAction : IAction { }
    public class LoadAnimalsAction : IAction { }
    public class ClearAnimalsAction : IAction { }

    public class ReceiverAnimalsAction : IAction
    {
        public IEnumerable<Animal> Animals { get; set; }
    }
}
