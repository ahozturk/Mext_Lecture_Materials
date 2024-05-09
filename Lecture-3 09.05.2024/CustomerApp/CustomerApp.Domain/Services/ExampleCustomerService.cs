using CustomerApp.Domain.Abstractions;
using CustomerApp.Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Services
{
    public class ExampleCustomerService : ICustomerService
    {
        public void Create(CustomerCreateDto customerCreateDto)
        {
            throw new NotImplementedException();
        }

        public List<CustomerListDto> List()
        {
            throw new NotImplementedException();
        }
    }
}
