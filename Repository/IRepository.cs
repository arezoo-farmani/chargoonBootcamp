using Repository.Models;
using System;
using System.Collections.Generic;


namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        void SaveAll(List<T> entities);
        Guid Save(T entity);
        T GetByGuid(Guid guid);
    }
}
