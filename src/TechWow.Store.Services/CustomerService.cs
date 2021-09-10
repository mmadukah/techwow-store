﻿using System.Collections.Generic;
using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Services.Abstractions;

namespace TechWow.Store.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Add(Customer model)
        {
            _repository.Add(model);
        }

        public void Add(IEnumerable<Customer> models)
        {
            _repository.Add(models);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public Customer Get(int id)
        {
            var model = _repository.Get(id);

            return model;
        }

        public IEnumerable<Customer> GetAll()
        {
            var models = _repository.GetAll();

            return models;
        }

        public void Update(Customer model)
        {
            _repository.Update(model);
        }

        public void Update(IEnumerable<Customer> models)
        {
            _repository.Update(models);
        }
    }
}
