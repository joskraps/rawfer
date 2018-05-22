using BlazorRedux;
using Rawfer.Shared;
using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Services;

namespace Rawfer.Client.Logic
{
    public static class ActionCreators
    {
        public static async Task LoadAnimals(Dispatcher<IAction> dispatch, HttpClient http)
        {
            dispatch(new LoadAnimalsAction());

            var animals = await http.GetJsonAsync<Animal[]>("/api/animals");

            dispatch(new ReceiveAnimalsAction
            {
                Animals = animals
            });
        }

        public static async Task AddAnimal(Dispatcher<IAction> dispatch, HttpClient http, Animal animalToAdd, IUriHelper helper)
        {
            await http.PostJsonAsync("/api/animals", animalToAdd);

            helper.NavigateTo("/animals");
            dispatch(new LoadAnimalsAction());
        }

        public static void Cancel(Dispatcher<IAction> dispatch, IUriHelper helper)
        {
            dispatch(new CancelAddAction());
            helper.NavigateTo("/animals");
        }
    }
}
