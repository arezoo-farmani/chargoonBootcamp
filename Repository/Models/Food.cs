﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Food
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Food GetFoodData(string name, decimal price)
        {
            var food = new Food
            {
                Name = name,
                Price = price
            };
            return food;

        }


    }
}