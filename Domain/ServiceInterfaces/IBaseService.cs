using Domain.DataInterfaces;
using System;

namespace Domain.ServiceInterfaces
{
    public interface IBaseService
    {
        Guid Save<T>(T entity) where T : IBaseEntity;
    }
}
