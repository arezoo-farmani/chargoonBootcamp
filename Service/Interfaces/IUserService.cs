using System;
using System.Collections.Generic;
using System.Linq;
using Repository.Models;

namespace Service.Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        void SaveAllUsers(List<User> users);
    }
}
