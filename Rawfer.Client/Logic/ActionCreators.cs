using BlazorRedux;
using Rawfer.Shared;
using Microsoft.AspNetCore.Blazor;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor.Services;
using System;

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
        public static void CancelAddAnimal(Dispatcher<IAction> dispatch, IUriHelper helper)
        {
            dispatch(new CancelAnimalAdd());
            helper.NavigateTo("/animals");
        }


        public static void CheckUser(Dispatcher<IAction> dispatch, IUriHelper helper)
        {

        }
        public static async Task CreateUser(Dispatcher<IAction> dispatch, HttpClient http, UserModel user)
        {
            dispatch(new CreateUserAction());

            var createdUser = await http.GetJsonAsync<UserModel>("");

            dispatch(new UserCreatedAction());
        }
        public static async Task Login(Dispatcher<IAction> dispatch, HttpClient http, UserModel user, IUriHelper helper)
        {
            dispatch(new ClearUserAction());

            var createdUser = await http.PostJsonAsync<UserModel>("/api/accounts/login", user);

            dispatch(new UserLoggedInAction(createdUser));

            helper.NavigateTo("/");
        }
        public static async Task LoadLoginProviders(Dispatcher<IAction> dispatch, HttpClient http)
        {
            dispatch(new LoadAnimalsAction());

            var providers = await http.GetJsonAsync<SigninProviderViewModel[]>("/api/accounts/providers");

            dispatch(new ReceiveProvidersAction
            {
                Providers = providers
            });
        }

        public static async Task LoadFood(Dispatcher<IAction> dispatch, HttpClient http)
        {
            dispatch(new LoadFoodsAction());

            var foodItems = await http.GetJsonAsync<FoodItem[]>("/api/food");

            dispatch(new ReceiveFoodsAction
            {
                FoodItems = foodItems
            });
        }
        public static async Task AddFood(Dispatcher<IAction> dispatch, HttpClient http, FoodItem foodItemToAdd, IUriHelper helper)
        {
            await http.PostJsonAsync("/api/food", foodItemToAdd);

            helper.NavigateTo("/food");
            dispatch(new LoadFoodsAction());
        }
    }
}
