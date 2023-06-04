using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Repository.Models;

namespace Repository
{
    public class DataRepository:IRepository
    {
        private readonly string UserFilePath;
        private readonly string RestaurantFilePath;

        public DataRepository()
        {
            this.UserFilePath = @"..\..\Files\users.json";
            this.RestaurantFilePath = @"..\..\Files\restaurant.json";
        }

        public List<User> GetAllUsers()
        {
            string jsonData = File.ReadAllText(UserFilePath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            return users ?? new List<User>();
        }

        public void SaveAllUsers(User newUser)
        {
            List<User> users = new List<User>();
            users.Add(newUser);
            this.SaveAllUsers(users);
        }

        public void SaveAllUsers(List<User> users)
        {
            string jsonData = JsonConvert.SerializeObject(users);
            File.WriteAllText(UserFilePath, jsonData);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            string jsonData = File.ReadAllText(RestaurantFilePath);
            List<Restaurant> restaurants = JsonConvert.DeserializeObject<List<Restaurant>>(jsonData);
            return  restaurants ?? new List<Restaurant>();
        }

        public void SaveAllRestaurants(Restaurant restaurant)
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            restaurants.Add(restaurant);
            this.SaveAllRestaurants(restaurants);
        }

        public void SaveAllRestaurants(List<Restaurant> restaurants)
        {
            string jsonData = JsonConvert.SerializeObject(restaurants);
            File.WriteAllText(RestaurantFilePath, jsonData);
        }
    }
}
