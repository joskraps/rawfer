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
}
