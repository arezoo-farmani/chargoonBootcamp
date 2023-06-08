using Domain.DataInterfaces;
using System;
using System.Collections.Generic;


namespace Domain.RepositoryInterfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        List<T> GetAll();
        void SaveAll(List<T> entities);
        Guid Save(T entity);
        T GetByGuid(Guid guid);
        void Update(T entity);
    }
}
