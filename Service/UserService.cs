using Domain.DataInterfaces;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Service
{
    public class UserService
    {
        public UserService()
        {
        }

        public T Exists<T>(string phoneNumber)
            where T : IBaseEntity, IPhoneNumber
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            List<T> itemList = dataRepository.GetAll();

            foreach (T item in itemList)
            {
                if (item.PhoneNumber == phoneNumber)
                    return item;
            }
            return default;
        }

        public Guid Save<T>(T entity) where T :IBaseEntity
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            Guid guid = dataRepository.Save(entity);
            return guid;
        }
    }
}
