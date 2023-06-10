using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.ServiceInterfaces
{
    public interface IFoodService
    {
        List<Food> GetAll();
        void Save(Food food);
        void Update(Food food);
    }
}
