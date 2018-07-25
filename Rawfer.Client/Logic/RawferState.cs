namespace Rawfer.Client.Logic
{
    using System.Collections.Generic;
    using Rawfer.Shared;
    using Rawfer.Shared.Models;

    public class RawferState
    {
        public IEnumerable<Animal> Animals { get; set; }

        public IEnumerable<FoodItem> FoodItems { get; set; }

        public IEnumerable<SigninProviderViewModel> Providers { get; internal set; }

        public UserModel User { get; set; }
    }
}