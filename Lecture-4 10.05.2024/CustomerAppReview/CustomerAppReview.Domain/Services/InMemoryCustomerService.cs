using CustomerAppReview.Domain.Abstractions;
using CustomerAppReview.Domain.DTOs;
using CustomerAppReview.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppReview.Domain.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        public void Add(AddCustomerDto addCustomerDto)
        {
            //create Method
        }

        public List<CustomerListDto> List()
        {
            //Getting All Customer
            return null;
        }
    }
}
