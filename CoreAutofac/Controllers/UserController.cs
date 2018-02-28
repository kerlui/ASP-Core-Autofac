using Core.Models;
using CoreAutofac.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAutofac.Controllers
{
    public class UserController : IUserApi
    {
        public Task<bool> Exists(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> Get(long id)
        {
            throw new NotImplementedException();
        }

        public Task<long> Post(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
