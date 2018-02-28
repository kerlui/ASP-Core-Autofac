using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAutofac.Services
{
    public interface IUserApi
    {
        Task<bool> Exists(string userName);

        Task<UserModel> Get(long id);

        Task<long> Post(UserModel model);


    }
}
