﻿using Domain.Models;
using Domain.ViewModels;
using System;
using System.Collections.Generic;

namespace Domain.ServiceInterfaces
{
    public interface IRestaurantService : IBaseService
    {
        List<RestaurantListViewModel> GetAll();
    }
}
