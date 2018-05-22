using BlazorRedux;
using Microsoft.AspNetCore.Blazor;
using Rawfer.Shared;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rawfer.Client.Logic
{
    public static class ActionCreators
    {
        public static async Task LoadAnimals(Dispatcher<IAction> dispatch, HttpClient http)
        {
            dispatch(new LoadAnimalsAction());

            var animals = await http.GetJsonAsync<Animal[]>("/api/animals/GetAnimals");
            Console.WriteLine(animals);
            dispatch(new ReceiverAnimalsAction
            {
                Animals = animals
            });
        }
    }
}
