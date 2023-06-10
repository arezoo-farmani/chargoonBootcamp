using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Domain.Models;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Service
{
    public class FoodService : IFoodService
    {
        private IRepository<Food> _repository;
        public FoodService()
        {
            this._repository = new DataRepository<Food>();
        }
        public List<Food> GetAll()
        {
            return _repository.GetAll();
        }
        public void Save(Food food)
        {
            food.Guid = Guid.NewGuid();
            _repository.Save(food);
        }
        public void Update(Food food)
        {
            _repository.Update(food);
        }

       
    }
}
