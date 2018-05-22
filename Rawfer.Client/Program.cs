using BlazorRedux;
using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Browser.Services;
using Rawfer.Client.Logic;

namespace Rawfer.Client
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new BrowserServiceProvider(services =>
            {
                services.AddReduxStore<RawferState, IAction>(new RawferState(), Reducers.RootReducer);
            });



            new BrowserRenderer(serviceProvider).AddComponent<App>("app");
        }
    }
}
