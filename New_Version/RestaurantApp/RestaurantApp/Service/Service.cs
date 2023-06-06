using System;
using System.Collections.Generic;
using RestaurantApp.BOLayer;
using RestaurantApp.BOLayer.Interfaces;
using RestaurantApp.RepositoryLayer;

namespace RestaurantApp.ServiceLayer
{
    public class Service
    {
        public Service()
        {
        }

        public T Exists<T>(string phoneNumber) 
            where T : BaseEntity, IPhoneNumeber
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            List<T> itemList = dataRepository.GetAll();

            foreach (T item in itemList)
            {
                if (item.PhoneNumber == phoneNumber)
                    return item;
            }
            return null;
        }

        public Guid Save<T>(T entity) where T : BaseEntity
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            Guid guid = dataRepository.Save(entity);
            return guid;
        }

        //public User UserExists(string phoneNumber)
        //{
        //    DataRepository<User> uRepository = new DataRepository<User>();
        //    List<User> userList = uRepository.GetAll();

        //    foreach (User user in userList)
        //    {
        //        if (user.PhoneNumber == phoneNumber)
        //            return user;
        //    }
        //    return null;
        //}

        //public Restaurant RestaurantExists(string phoneNumber)
        //{
        //    DataRepository<Restaurant> rRepository = new DataRepository<Restaurant>();
        //    List<Restaurant> restaurantList = rRepository.GetAll();

        //    foreach (Restaurant restaurant in restaurantList)
        //    {
        //        if (restaurant.PhoneNumber == phoneNumber)
        //            return restaurant;
        //    }
        //    return null;
        //}
    }
}
