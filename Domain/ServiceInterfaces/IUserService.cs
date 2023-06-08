using System.Collections.Generic;
using Domain.Models;

namespace Domain.ServiceInterfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        void SaveAll(List<User> users);
    }
}
