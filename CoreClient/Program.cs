using CoreAutofac.Services;
using Refit;
using System;

namespace CoreClient
{
    class Program
    {
        static async void Main(string[] args)
        {
            var userApi = RestService.For<IUserApi>("https://api.github.com");

            var userExists = await userApi.Exists("admin");

        }
    }
}
