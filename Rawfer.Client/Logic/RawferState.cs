using Rawfer.Shared;
using System.Collections.Generic;

namespace Rawfer.Client.Logic
{
    public class RawferState
    {
        public UserModel User { get; set; }
        public IEnumerable<Animal> Animals { get; set; }
        public IEnumerable<SigninProviderViewModel> Providers { get; internal set; }
    }
}
