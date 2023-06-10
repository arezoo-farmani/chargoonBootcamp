using Domain.DataInterfaces;
using Domain.ServiceInterfaces;
using Repository;
using System;


namespace Service
{
    public class BaseService : IBaseService
    {
        public Guid Save<T>(T entity) where T : IBaseEntity
        {
            DataRepository<T> dataRepository = new DataRepository<T>();
            entity.Guid = Guid.NewGuid();
            Guid entityGuid = dataRepository.Save(entity);
            return entityGuid;
        }
    }
}
