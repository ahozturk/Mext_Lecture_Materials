using CustomerApp.Domain.Dtos;
using CustomerApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Domain.Abstractions
{
    public interface ICustomerService
    {
        void Create(CustomerCreateDto customerCreateDto);
        List<CustomerListDto> List();
    }
}
