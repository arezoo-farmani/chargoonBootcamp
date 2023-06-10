using Domain.DataInterfaces;
using Repository;
using System.Collections.Generic;


namespace Service
{
    public static class Helper
    {
        public static T GetEntityByPhoneNumber<T>(string phoneNumber) where T : IBaseEntity, IPhoneNumber
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            List<T> itemList = dataRepository.GetAll();
            foreach (T item in itemList)
            {
                if (item.PhoneNumber == phoneNumber)
                    return item;
            }
            return default(T);
        }

        public static bool IsAnyEntityExist<T>() where T : IBaseEntity
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            return dataRepository.GetAll()?.Count > 0 ? true : false;
        }
    }
}
