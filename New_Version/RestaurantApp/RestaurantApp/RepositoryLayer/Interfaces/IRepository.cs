using System;
using System.Collections.Generic;
using RestaurantApp.BOLayer;

namespace RestaurantApp.RepositoryLayer.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        void SaveAll(List<T> entities);
        Guid Save(T entity);
        T GetByGuid(Guid guid);
    }
}
