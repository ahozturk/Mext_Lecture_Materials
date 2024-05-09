using CustomerApp.Domain.Abstractions;
using CustomerApp.Domain.Dtos;
using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        static List<Customer> customers = new();

        static InMemoryCustomerService()
        {
            Customer customer1 = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Surname = "Doe"
            };

            Customer customer2 = new Customer
            {
                Id = Guid.NewGuid(),
                Name = "Jane",
                Surname = "Smith"
            };
            
            customers.Add(customer1);
            customers.Add(customer2);
        }

        public void Create(CustomerCreateDto customerCreateDto)
        {
            Customer customer = new()
            {
                Id = Guid.NewGuid(),
                Name = customerCreateDto.Name,
                Surname = customerCreateDto.Surname,
            };

            customers.Add(customer);
        }

        public List<CustomerListDto> List()
        {
            return customers
                .Select(x => new CustomerListDto()
                {
                    Id = x.Id,
                    Name = x.Name,
                }).ToList();
        }
    }
}
