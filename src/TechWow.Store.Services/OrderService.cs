using System.Collections.Generic;
using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Services.Abstractions;

namespace TechWow.Store.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            _repository = repository;
        }

        public void Add(Order model)
        {
            _repository.Add(model);
        }

        public void Add(IEnumerable<Order> models)
        {
            _repository.Add(models);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Order Get(int id)
        {
            var model = _repository.Get(id);

            return model;
        }

        public IEnumerable<Order> GetAll()
        {
            var models = _repository.GetAll();

            return models;
        }

        public void Update(Order model)
        {
            _repository.Update(model);
        }

        public void Update(IEnumerable<Order> models)
        {
            _repository.Update(models);
        }
    }
}
