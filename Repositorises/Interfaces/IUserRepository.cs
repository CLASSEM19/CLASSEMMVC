using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CLASSEM_MVC_PRO.Models.Entities;

namespace CLASSEM_MVC_PRO.Repositorises.Interfaces
{
    public interface IUserRepository
    {
        User Create(User user);
        User Login(string email, string password);
        void Delete(User user);
        User GetById(string userId);
        User UpdatePassword(User user);

    }
}